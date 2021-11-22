using EFTutorial.DAL;
using EFTutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial.BLL
{
    internal class LopHocBLL
    {
        public enum KETQUA
        {
            ThanhCong, TenTrung
        }
        public static List<LopHoc> GetList()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            return model.LopHocs.OrderByDescending(e=>e.Name).ToList();
            
        }

        public static List<LopHocVM> GetListVM()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.LopHocs.Select(e => new LopHocVM
            {
                ID = e.ID,
                Name = e.Name,
                TotalStudent = e.SinhViens.Count()
            }).ToList();
            return ls;
        }

        public static void Delete(long id)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHocs.Where(e => e.ID == id).FirstOrDefault();
            if (lop != null)
                model.LopHocs.Remove(lop);
            else
                throw new Exception("Lớp học không tồn tại");
            model.SaveChanges();
        }

        public static KETQUA Add(LopHocVM lophocVM)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHocs.Where(e => e.Name == lophocVM.Name).FirstOrDefault();
            if (lop != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                lop = new LopHoc
                {
                    Name = lophocVM.Name
                };
                model.LopHocs.Add(lop);
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }

        public static KETQUA Update(LopHocVM lophocVM)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHocs.Where(e =>
            e.ID != lophocVM.ID &&
            e.Name == lophocVM.Name).FirstOrDefault();
            if(lop != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                lop = model.LopHocs.Where(e => e.ID == lophocVM.ID).FirstOrDefault();
                lop.Name = lophocVM.Name;
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
           
        }
    }
}
