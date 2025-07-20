using MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.GenericRepository
{
    public interface ICoreService<T> where T : CoreEntity
    {
        // Ekle
        bool Create(T entity);

        // Güncelle
        bool Update(T entity);

        // Sil
        bool Delete(T entity);

        // Listele
        List<T> GetAll();

        // Tek Kayıt
        T Get(int id);
    }
}