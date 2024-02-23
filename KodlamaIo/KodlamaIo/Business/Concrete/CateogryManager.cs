using KodlamaIo.Business.Abstracts;
using KodlamaIo.DataAcces.Abstracts;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concrete;

public class CateogryManager : ICategoryManager
{
    private ICategoryDal _categoryDal;
    public CateogryManager(ICategoryDal categoryDal)
    {

        _categoryDal = categoryDal;

    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete()
    {
        _categoryDal.Delete();
    }

    public List<Category> GetAllCategory()
    {
        return _categoryDal.GetAllCategory();
    }

    

    public void Update()
    {
        _categoryDal.Update();
    }
}
