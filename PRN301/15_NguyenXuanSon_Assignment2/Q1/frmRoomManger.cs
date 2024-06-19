using Microsoft.EntityFrameworkCore;
using Q1.Models;

namespace Q1
{
    public partial class frmRoomManger : Form
    {
        PE_PRN_Fall2023B1Context _context = new PE_PRN_Fall2023B1Context();

        public frmRoomManger()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            List<Room> rooms = _context.Rooms.ToList();
            cboRooms.DataSource = rooms;
            cboRooms.DisplayMember = "Title";
            cboRooms.ValueMember = "Id";

            cboMovie.DataSource = _context.Movies.ToList();
            cboMovie.DisplayMember = "Title";
            cboMovie.ValueMember = "Id";

            cboTimeSlot.DataSource = _context.TimeSlots.ToList();
            cboTimeSlot.DisplayMember = "TimeString";
            cboTimeSlot.ValueMember = "Id";
        }

        private void Loadschedule()
        {
            List<Schedule> schedules = _context.Schedules.
                Include(x => x.Room).Include(x => x.Movie).Include(x => x.TimeSlot).ToList();
            if (cboRooms.SelectedItem != null)
            {
                schedules = schedules.Where(x => x.RoomId == (cboRooms.SelectedItem as Room).Id).ToList();
            }

            dgvListView.DataSource = schedules.Select(x => new
            {
                x.Id,
                Room = x.Room.Title,
                Movie = x.Movie != null ? x.Movie.Title : null,
                TimeSlot = (x.TimeSlot != null) ? (x.TimeSlot.TimeString) : "",
                x.StartDate,
                x.EndDate,
                x.Note
            }).ToList();
        }

        private void cboRooms_TextChanged(object sender, EventArgs e)
        {
            Loadschedule();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            bool check = false;
            int idTimeslot = (cboTimeSlot.SelectedItem as TimeSlot).Id;
            int idRooms = (cboRooms.SelectedItem as Room).Id;
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                check = true;

            }
            else
            {

                Schedule schedule = _context.Schedules.
                    FirstOrDefault(x => x.StartDate <= dtpStartDate.Value && x.EndDate >= dtpEndDate.Value
                    && x.TimeSlotId == idTimeslot && x.RoomId == idRooms);
                if (schedule != null)
                {
                    check = true;
                }
            }
            if (check)
            {
                MessageBox.Show("The screening schedule does not meet the conditions and cannot be added to the database","Warnning");
                return;
            }
            else
            {
                Schedule schedule = new Schedule();
                schedule.TimeSlotId = idTimeslot;
                schedule.RoomId = idRooms;
                schedule.StartDate = dtpStartDate.Value;
                schedule.EndDate = dtpEndDate.Value;
                schedule.MovieId = (cboMovie.SelectedItem as Movie).Id;

                _context.Schedules.Add(schedule);
                _context.SaveChanges();
                MessageBox.Show("Add a new Schedule successfully", "Successful");
                Loadschedule();
            }
        }

        private void dgvListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvListView.Rows[e.RowIndex];

                string roomTitle = Convert.ToString(selectedRow.Cells["Room"].Value);
                string movieTitle = Convert.ToString(selectedRow.Cells["Movie"].Value);
                string timeSlot = Convert.ToString(selectedRow.Cells["TimeSlot"].Value);
                DateTime startDate = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                DateTime endDate = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
                string note = Convert.ToString(selectedRow.Cells["Note"].Value);

                cboMovie.Text = movieTitle;
                cboTimeSlot.Text = timeSlot;
                dtpStartDate.Text = startDate.ToString("yyyy-MM-dd");
                dtpEndDate.Text = endDate.ToString("yyyy-MM-dd");
            }
        }
    }
}
