using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _221_Kubar_02.Connection;
namespace _221_Kubar_02
{
    internal class MaterialDeffect
    {
        public static int MatDef(int productId, int materialType, int quantity, double par1, double par2)
        {
            double result;
            var TypeProduct = GetContext().ProductsType.Where(x => x.ProductsTypeID == productId);
            var typeMaterial = GetContext().MaterialType.Where(x => x.materialType1 == materialType);
            if (TypeProduct.Count() < 1 | typeMaterial.Count() < 1 | quantity < 1 | par1 <= 0 | par2 <= 0)
                return -1;
            else
            {
                double coeff = (double)TypeProduct.Select(x => x.Ratio).FirstOrDefault();
                double materCount = quantity + quantity * typeMaterial.Select(x => x.DefectPercent).FirstOrDefault();
                result = materCount * par1 * par2 * coeff;
                return (int)Math.Ceiling(result);
            }

        }
    }
}
