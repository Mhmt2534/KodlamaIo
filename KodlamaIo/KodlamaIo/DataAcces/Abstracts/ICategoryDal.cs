﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAcces.Abstracts;

public interface ICategoryDal
{
    public void Add();
    public void Delete();
    public void Update();
}
