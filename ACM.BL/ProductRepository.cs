using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {

            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Book";
                product.ProductDescription = "Essay in understanding human nature";
                product.CurrentPrice = (decimal?)10.2;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsValid)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        // call an update Stored Procedure
                    }
                }
                else 
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
