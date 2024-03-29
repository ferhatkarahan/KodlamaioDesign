﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Category GetCategory(int id);
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
    }
}
