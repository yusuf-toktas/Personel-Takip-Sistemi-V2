using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Sistemi.Siniflar
{
    public class Repository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public Repository()
        {
            _dbSet = Baglanti.db.Set<T>();
        }

        // Listeleme
        public List<T> Listele()
        {
            return _dbSet.ToList();
        }

        public List<T> Listele(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public T Bul(Expression<Func<T, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        public void Ekle(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                Baglanti.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası: " + ex.Message);
            }
        }
        public void Guncelle(T entity)
        {
            try
            {
                Baglanti.db.Entry(entity).State = EntityState.Modified;
                Baglanti.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }

        public void Sil(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                Baglanti.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
            }
        }

        public void Sil(int id)
        {
            try
            {
                var entity = _dbSet.Find(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    Baglanti.db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
            }
        }
    }
}