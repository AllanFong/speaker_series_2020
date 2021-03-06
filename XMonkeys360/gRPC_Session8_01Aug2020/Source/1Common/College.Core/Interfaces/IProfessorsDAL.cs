﻿using College.Core.Entities;
using System;
using System.Collections.Generic;

namespace College.Core.Interfaces
{

    public interface IProfessorsDAL
    {
        Professor AddProfessor(Professor professor);

        IEnumerable<Professor> GetAllProfessors();

        Professor GetProfessorById(Guid professorId);
    }

}
