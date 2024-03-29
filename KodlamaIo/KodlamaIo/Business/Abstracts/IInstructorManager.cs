﻿using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts;

public interface IInstructorManager
{
    public List<Instructor> GetAllInstructor();
    public void Add(Instructor instructor);
    public void Update();
    public void Delete();
}
