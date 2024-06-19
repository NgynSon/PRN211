using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class frmMovieManager : Form
    {
        private Schedule selectedSchedule;
        PE_PRN_Fall2023B1Context _context = new PE_PRN_Fall2023B1Context();
        public frmMovieManager()
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

/*            cboMovie.DataSource = _context.Movies.ToList();
*/            cboMovie.DisplayMember = "Title";
            cboMovie.ValueMember = "Id";

            cboTimeSlot.DataSource = _context.TimeSlots.ToList();
            cboTimeSlot.DisplayMember = "TimeString";
            cboTimeSlot.ValueMember = "Id";
        }

        private void Loadschedule()
        {
            List<Schedule> schedules = _context.Schedules.
                Include(x => x.Room).Include(x => x.Movie).Include(x => x.TimeSlot).ToList();
            if (cboMovie.SelectedItem != null)
            {
                schedules = schedules.Where(x => x.MovieId == (cboMovie.SelectedItem as Movie).Id).ToList();
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

        private void cboMovie_TextChanged(object sender, EventArgs e)
        {
            Loadschedule();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            bool check = false;
            int idTimeslot = (cboTimeSlot.SelectedItem as TimeSlot).Id;
            int idMovie = (cboMovie.SelectedItem as Movie).Id;

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                check = true;
            }
            else
            {

                Schedule schedule = _context.Schedules.
                    FirstOrDefault(x => x.StartDate <= dtpStartDate.Value && x.EndDate >= dtpEndDate.Value
                    && x.TimeSlotId == idTimeslot && x.MovieId == idMovie);
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
                schedule.TimeSlotId = idTimeslot;
                schedule.RoomId = (cboRooms.SelectedItem as Room).Id;
                schedule.StartDate = dtpStartDate.Value;
                schedule.EndDate = dtpEndDate.Value;
                schedule.MovieId = idMovie;

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
                int selectedScheduleId = Convert.ToInt32(dgvListView.Rows[e.RowIndex].Cells["Id"].Value);

                selectedSchedule = _context.Schedules
                    .Include(x => x.Room)
                    .Include(x => x.Movie)
                    .Include(x => x.TimeSlot)
                    .FirstOrDefault(x => x.Id == selectedScheduleId);

                if (selectedSchedule != null)
                {
                    cboRooms.SelectedValue = selectedSchedule.RoomId;
                    cboMovie.SelectedValue = selectedSchedule.MovieId;
                    cboTimeSlot.SelectedValue = selectedSchedule.TimeSlotId;
                    dtpStartDate.Value = selectedSchedule.StartDate;
                    dtpEndDate.Value = selectedSchedule.EndDate;
                }
            }
        }


        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {

            if (selectedSchedule != null)
            {
                selectedSchedule.RoomId = (int)cboRooms.SelectedValue;
                selectedSchedule.MovieId = (int)cboMovie.SelectedValue;
                selectedSchedule.TimeSlotId = (int)cboTimeSlot.SelectedValue;
                selectedSchedule.StartDate = dtpStartDate.Value;
                selectedSchedule.EndDate = dtpEndDate.Value;

                _context.SaveChanges();

                MessageBox.Show("Schedule updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Loadschedule();
            }
            else
            {
                MessageBox.Show("Please select a schedule to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkRoom_Click(object sender, EventArgs e)
        {
            frmRoomManger frmRoomManger = new frmRoomManger();
            frmRoomManger.ShowDialog();
        }
    }
}
