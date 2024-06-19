using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System.Reflection;

namespace Q1
{
    public partial class Form1 : Form
    {
        public PE_PRN_Fall2023B1Context context = new PE_PRN_Fall2023B1Context();
        public Form1()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGridView();
        }
        private void LoadComboBox()
        {
            // Load data into ComboBox
            cbRooms.DataSource = context.Rooms.ToList();
            cbRooms.ValueMember = "Id";
            cbRooms.DisplayMember = "Title";


            cbMovies.DataSource = context.Movies.ToList();
            cbMovies.ValueMember = "Id";
            cbMovies.DisplayMember = "Title";

            cbRoom.DataSource = context.Rooms.ToList();
            cbRoom.ValueMember = "Id";
            cbRoom.DisplayMember = "Title";

            cbTimeSlot.DataSource = context.TimeSlots.ToList();
            cbTimeSlot.ValueMember = "Id";
            cbTimeSlot.DisplayMember = "FormattedTimeRange";
        }

        private void LoadDataGridView()
        {
            // Load data into DataGridView
            dgvSchedule.DataSource = (
                from s in context.Schedules
                join r in context.Rooms on s.RoomId equals r.Id
                join t in context.TimeSlots on s.TimeSlotId equals t.Id
                join movi in context.Movies on s.MovieId equals movi.Id
                select new
                {
                    s.Id,
                    Room = r.Title,
                    Movie = movi.Title,
                    TimeSlot = $"{t.StartTime} - {t.EndTime}",
                    s.StartDate,
                    s.EndDate,
                    s.Note,
                }).ToList();
        }
        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRooms.SelectedValue != null)
            {

                Room selectedRoom = (Room)cbRooms.SelectedItem;
                int selectedRoomId = selectedRoom.Id;


                dgvSchedule.DataSource = (
                    from s in context.Schedules
                    join r in context.Rooms on s.RoomId equals r.Id
                    join t in context.TimeSlots on s.TimeSlotId equals t.Id
                    join movi in context.Movies on s.MovieId equals movi.Id
                    where s.RoomId == selectedRoomId
                    select new
                    {
                        s.Id,
                        Room = r.Title,
                        Movie = movi.Title,
                        TimeSlot = $"{t.StartTime} - {t.EndTime}",
                        s.StartDate,
                        s.EndDate,
                        s.Note,
                    }).ToList();
            }
        }

        private void btAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                Schedule sche = new Schedule();
                sche.Note = tbNote.Text;

                if (string.IsNullOrEmpty(sche.Note) == false)
                {
                    sche.MovieId = int.Parse(cbMovies.SelectedValue.ToString());
                    sche.RoomId = int.Parse(cbRoom.SelectedValue.ToString());
                    sche.TimeSlotId = int.Parse(cbTimeSlot.SelectedValue.ToString());
                    sche.Note = tbNote.Text;
                    sche.StartDate = dtpStartDate.Value;
                    sche.EndDate = dtpEndDate.Value;

                    bool scheduleExists = context.Schedules
                        .Any(s => s.RoomId == sche.RoomId && s.TimeSlotId == sche.TimeSlotId
                               && (s.StartDate <= sche.StartDate && s.EndDate >= sche.StartDate
                                   || s.StartDate <= sche.EndDate && s.EndDate >= sche.EndDate));

                    if (!scheduleExists)
                    {
                        context.Schedules.Add(sche);
                        context.SaveChanges();
                        MessageBox.Show("Add new schedule");
                    }
                    else
                    {
                        MessageBox.Show("Schedule with the same Room and TimeSlot already exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Note not null ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}