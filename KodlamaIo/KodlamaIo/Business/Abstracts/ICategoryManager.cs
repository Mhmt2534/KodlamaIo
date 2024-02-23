using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts;

public interface ICategoryManager
{
    public List<Category> GetAllCategory();
    public void Add();
    public void Update();
    public void Delete();
}
