﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal class MemberRepository : IMemberRepository
    {
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);

        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);

        public Member GetMailAndPassword(string _Email, string _Password)
        {
            return MemberDAO.Instance.GetEmailAndPassword(_Email, _Password);
        }
    }
}
