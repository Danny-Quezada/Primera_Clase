using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public abstract class BaseServices<T>: IServices<T>
    {
        private IActivoModel<T> Model;
        protected BaseServices(IActivoModel<T> model)
        {
            this.Model = model;
        }

        public void Add(T t)
        {
             Model.Add(t);
        }

        public void Delete(T t)
        {
            Model.Add(t);
        }

        public List<T> Read()
        {
            return Model.Read();
        }
    }
}
