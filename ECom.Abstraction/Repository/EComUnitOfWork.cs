using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Ecom.DataModel;
using System.Transactions;
using ECom.DataModel;
using ECom.Dto;

namespace ECom.Abstraction.Repository
{
    public class EComUnitOfWork : IDisposable
    {

        private EcomContext context = null;
        private bool _disposed = false;
      

        #region Repository Variables
        private GenericRepository<Customer> _customerRepository;
        private GenericRepository<Category> _categoryRepository;
        private GenericRepository<Address> _addressRepository;
        private GenericRepository<ProductImage> _productImageRepository;
        private GenericRepository<PriceTag> _priceTagRepository;
        private GenericRepository<Product> _productRepository;
        
        
        #endregion

        public EComUnitOfWork()
        {
            context = new DataModel.EcomContext();
            context.Configuration.ProxyCreationEnabled = false;
            //context.Configuration.LazyLoadingEnabled = true;
            context.Database.CommandTimeout = 300;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    context.SaveChanges();
                    scope.Complete();
                }
                catch (DbEntityValidationException ex)
                {
                    throw new DbEntityValidationException(ex.Message);
                }
            }
        }
        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (this._customerRepository == null)
                {
                    this._customerRepository = new GenericRepository<Customer>(context);
                }
                return _customerRepository;
            }
        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this._categoryRepository == null)
                {
                    this._categoryRepository = new GenericRepository<Category>(context);
                }
                return _categoryRepository;
            }
        }

        public GenericRepository<Address> AddressRepository
        {
            get
            {
                if (this._addressRepository == null)
                {
                    this._addressRepository = new GenericRepository<Address>(context);
                }
                return _addressRepository;
            }
        }

        public GenericRepository<ProductImage> ProductImageRepository
        {
            get
            {
                if (this._productImageRepository == null)
                {
                    this._productImageRepository = new GenericRepository<ProductImage>(context);
                }
                return _productImageRepository;
            }
        }

        public GenericRepository<PriceTag> PriceTagRepository
        {
            get
            {
                if (this._priceTagRepository == null)
                {
                    this._priceTagRepository = new GenericRepository<PriceTag>(context);
                }
                return _priceTagRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this._productRepository == null)
                {
                    this._productRepository = new GenericRepository<Product>(context);
                }
                return _productRepository;
            }
        }
    }
}
