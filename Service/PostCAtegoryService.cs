using Data.Infrastructure;
using Data.Repositories;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPostCAtegoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetByID(int id);
    }
    public class PostCategoryService : IPostCAtegoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private UnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryRepository , UnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public PostCategory GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }
    }
}
