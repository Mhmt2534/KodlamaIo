using KodlamaIo.DataAcces.Abstracts;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAcces.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> listCategories;
    public CategoryDal()
    {
        Category category1 = new Category();
        category1.CategoryId = 1;
        category1.CategoryName = "Tümü";

        Category category2 = new Category();
        category2.CategoryId = 2;
        category2.CategoryName = "Programlama (8)";

        listCategories= new List<Category> {category1,category2};
    }

    public void Add(Category category)
    {
        listCategories.Add(category);
    }

    public void Delete()
    {
        Console.WriteLine("Kategori Silindi");
    }

    public void Update()
    {
       Console.WriteLine("Kategori Güncellendi");
    }


    public List<Category> GetAllCategory()
    {

        return listCategories;
    }


}
