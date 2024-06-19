using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Q2_Demo3.Models;

namespace Q2_Demo3
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            using (var context = new PRN211_Spr22Context())
            {
                var sv = context.Services.Select(sv => sv.RoomTitle).Distinct();
                cb_Room.DataSource = sv.ToList();
                var fee = context.Services.Select(fee => fee.FeeType).Distinct();
                cb_Fee.DataSource = fee.ToList();
            }
            cb_Room.SelectedIndex = 0;
            cb_Fee.SelectedIndex = 0;
            Filter();
            cb_Room.SelectedIndexChanged += (sender, e) => Filter();
            cb_Fee.SelectedIndexChanged += (sender, e) => Filter();

        }

        /*public void Load()
        {
            using (var context = new PRN211_Spr22Context())
            {
                var sv = context.Services.Select(sv => sv.RoomTitle).Distinct();
                cb_Room.DataSource = sv.ToList();
                var fee = context.Services.Select(fee => fee.FeeType).Distinct();
                cb_Fee.DataSource = fee.ToList();

                var query = context.Services.Include(e => e.RoomTitleNavigation).Select(e => new
                {
                    e.RoomTitle,
                    Floor = e.RoomTitleNavigation.Floor,
                    Square = e.RoomTitleNavigation.Square,
                    e.Month,
                    e.Year,
                    e.FeeType,
                    e.Amount,
                    e.PaymentDate,
                    e.Employee
                }).ToList();
                dataGridView1.DataSource = query;
            }
        }*/

        public void Filter()
        {
            using (var con = new PRN211_Spr22Context())
            {
                var query = con.Services.Include(sv => sv.RoomTitleNavigation).AsQueryable();
                string room = cb_Room.SelectedItem?.ToString();
                string fee = cb_Fee.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(room))
                {
                    query = query.Where(sv => sv.RoomTitle == room);
                }
                if (!string.IsNullOrEmpty(fee))
                {
                    query = query.Where(sv => sv.FeeType == fee);
                }
                var sv = query.Select(sv => new
                {
                    sv.RoomTitle,
                    Floor = sv.RoomTitleNavigation.Floor,
                    Square = sv.RoomTitleNavigation.Square,
                    sv.Month,
                    sv.Year,
                    sv.FeeType,
                    sv.Amount,
                    sv.PaymentDate,
                    sv.Employee
                });
                dataGridView1.DataSource = sv.ToList();
            }
        }
    }
}