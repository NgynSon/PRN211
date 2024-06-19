using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        public MemberDAO()
        {
        }

        //-- gọi list từ đb lên
        public IEnumerable<Member> GetMemberList()
        {
            using FStoreContext dbContext = new FStoreContext();

            var members = dbContext.Members.ToList();
            return members;
        }

        // Add new member
        public void AddNew(Member member)
        {
            try
            {
                using FStoreContext dbContext = new FStoreContext();
                dbContext.Members.Add(member);
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Add Update member
        public void Update(Member member)
        {
            try
            {
                using FStoreContext dbContext = new FStoreContext();
                dbContext.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void Remove(int memberId)
        {
            Console.WriteLine($"member ID {memberId}");
            try
            {
                using FStoreContext dBContext = new FStoreContext();

                var member = dBContext.Members.SingleOrDefault(members => members.MemberId == memberId);
                //   Console.WriteLine("Lay ra được một member: "  + member);
                if (member != null)

                {
                    //     Console.WriteLine("toi dung trc ham remove" + member);
                    //  dBContext.Attach(member);
                    dBContext.Remove(member);
                    //   Console.WriteLine("Da xoa mot member");

                    dBContext.SaveChanges();
                    // Console.WriteLine("Da luu xuong dataabase");

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Member GetEmailAndPassword(string _Email, string _Password)
        {
            FStoreContext dbContext = new FStoreContext();
            Member? member = dbContext.Members.Where(mem => mem.Email == _Email && mem.Password == _Password).FirstOrDefault();
            return member;
        }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
    }
}
