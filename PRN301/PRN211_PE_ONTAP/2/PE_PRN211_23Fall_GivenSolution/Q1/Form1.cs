using Microsoft.EntityFrameworkCore;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        PE_PRN_Fall2023B1Context context = new PE_PRN_Fall2023B1Context();

        public Form1()
        {
            InitializeComponent();
            Load();
            LoadSchedule();
        }

        private void Load()
        {
            List<Room> rooms = context.Rooms.ToList();
            cboRooms.DataSource = rooms;
            cboRooms.DisplayMember = "Title";
            cboRooms.ValueMember = "Id";

            cboMovies.DataSource = context.Movies.ToList();
            cboMovies.DisplayMember = "Title";
            cboMovies.ValueMember = "Id";

            cboTimeSlot.DataSource = context.TimeSlots.ToList();
            cboTimeSlot.DisplayMember = "TimeString";
            cboTimeSlot.ValueMember = "Id";
        }

        private void LoadSchedule()
        {
            List<Schedule> schedules = context.Schedules
                .Include(x => x.Room).Include(y => y.Movie).Include(x => x.TimeSlot)
                .ToList();

            if (cboRooms.SelectedItem != null)
            {
                schedules = schedules.Where(x => x.RoomId == (cboRooms.SelectedItem as Room).Id).ToList();
            }

            dgvSchedules.DataSource = schedules.ToList().Select(x => new
            {
                x.Id,
                x.Room.Title,
                Movie = (x.Movie != null) ? x.Movie.Title : "",
                TimeSlot = (x.TimeSlot != null) ? (x.TimeSlot.TimeString) : "",
                x.StartDate,
                x.EndDate,
                x.Note,
            }).ToList();
        }

        private void cboRooms_TextChanged(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            int idTimeSlot = ((TimeSlot)cboTimeSlot.SelectedItem).Id;
            int idRooms = ((Room)cboRooms.SelectedItem).Id;
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                check = true;
            }
            else
            {
                Schedule schedule = context.Schedules
                    .FirstOrDefault(x => x.StartDate <= dtpStartDate.Value && x.EndDate >= dtpStartDate.Value
                    && x.TimeSlotId == idTimeSlot && x.RoomId == idRooms);
                if (schedule != null)
                {
                    check = true;
                }
            }


            if (check)
            {
                MessageBox.Show("The screening schedule does not meet the conditions and cannot be added to the database");
                return;
            }
            else
            {
                Schedule schedule = new Schedule();
                schedule.TimeSlotId = idTimeSlot;
                schedule.RoomId = idRooms;
                schedule.StartDate = dtpStartDate.Value;
                schedule.EndDate = dtpEndDate.Value;
                schedule.MovieId = (cboMovies.SelectedItem as Movie).Id;

                context.Schedules.Add(schedule);
                context.SaveChanges();
                LoadSchedule();
            }


        }
    }
}