﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();

        void InsertMember(Member member);

        void UpdateMember(Member member);

        void DeleteMember(int memberId);

        Member GetMailAndPassword(string _Email, string _Password);

    }
}
