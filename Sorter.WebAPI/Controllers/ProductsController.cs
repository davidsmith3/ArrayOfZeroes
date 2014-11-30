using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Sorter.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {

        public string GetAllProducts() {
            return "hello";
        }

        public string GetProductById(int id) {
            string s = id.ToString();
            return s;
            /*char[] c = s.ToCharArray();
            int[] nums = new int[c.Length];
            for (int i = 0; i < c.Length; i++) {
                nums[i] = Convert.ToInt32(c[i]);
            }

            SorterCS.Sorter sorter = new SorterCS.Sorter();
            nums = sorter.Sort(nums);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nums.Length; i++) {
                sb.Append(nums[i]);
            }
            return sb.ToString(); */
        }
    }
}
