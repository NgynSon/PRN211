using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCbData();
            LoadGridData();
            dtStartDate.CustomFormat = "dddd, MMM, yyyy";
            dtEndDate.CustomFormat = "dddd, MMM, yyyy";
        }

        private void LoadGridData()
        {
            using (PE_PRN_Fall2023B1Context ctx = new PE_PRN_Fall2023B1Context())
            {
                var data = (from schedule in ctx.Schedules
                            join room in ctx.Rooms on schedule.RoomId equals room.Id
                            join movie in ctx.Movies on schedule.MovieId equals movie.Id
                            join timeslot in ctx.TimeSlots on schedule.TimeSlotId equals timeslot.Id
                            where schedule.RoomId == ((Room)cbRooms.SelectedItem).Id
                            select new
                            {
                                Id = schedule.Id,
                                Room = room.Title,
                                Movie = movie.Title,
                                TimeSlot = (string.IsNullOrEmpty(schedule.TimeSlotId.ToString())) ? "" : timeslot.StartTime.ToString(@"hh\:mm\:ss") + " - " + timeslot.EndTime.ToString(@"hh\:mm\:ss"),
                                StartDate = schedule.StartDate.ToString("dd/MM/yyyy"),
                                EndDate = schedule.EndDate.ToString("dd/MM/yyyy"),
                                Note = string.IsNullOrEmpty(schedule.Note) ? "" : schedule.Note,
                            }).ToList();
                dgSchedule.DataSource = data;
            }
        }

        private void LoadCbData()
        {
            using (PE_PRN_Fall2023B1Context ctx = new PE_PRN_Fall2023B1Context())
            {
                cbRooms.DataSource = ctx.Rooms.ToList();
                cbRooms.DisplayMember = "Title";
                cbRooms.ValueMember = "Id";

                cbMovie.DataSource = ctx.Movies.ToList();
                cbMovie.DisplayMember = "Title";
                cbMovie.ValueMember = "Id";

                var timeslots = (from ts in ctx.TimeSlots
                                 select new
                                 {
                                     Id = ts.Id,
                                     Time = ts.StartTime.ToString(@"hh\:mm\:ss") + " - " + ts.EndTime.ToString(@"hh\:mm\:ss")
                                 }).ToList();
                cbTimeSlot.DataSource = timeslots;
                cbTimeSlot.DisplayMember = "Time";
                cbTimeSlot.ValueMember = "Id";
            }
        }

        private Schedule getSchedule()
        {
            try
            {
                Schedule schedule = new Schedule();
                schedule.RoomId = ((Room)cbRooms.SelectedItem).Id;
                schedule.MovieId = ((Movie)cbMovie.SelectedItem).Id;
                schedule.TimeSlotId = ((dynamic)cbTimeSlot.SelectedItem).Id;
                if (dtStartDate.Value >= dtEndDate.Value)
                {
                    throw new Exception("The screen schedule does not meet the condition and cannot added to database");
                }
                schedule.StartDate = dtStartDate.Value;
                schedule.EndDate = dtEndDate.Value;
                return schedule;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (PE_PRN_Fall2023B1Context ctx = new PE_PRN_Fall2023B1Context())
                {
                    Schedule schedule = getSchedule();
                    ctx.Schedules.Add(schedule);
                    ctx.SaveChanges();
                    MessageBox.Show("Add successful!");
                    LoadGridData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}