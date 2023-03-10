using AutoMapper;
using BookStore.Application.Dtos.Category;
using BookStore.Application.Repositories.CategoryRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Category.GetCategoriesWithSub
{
    public class GetCategoriesWithSubQueryHandler : IRequestHandler<GetCategoriesWithSubQueryRequest, GetCategoriesWithSubQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly IMapper _mapper;

        public GetCategoriesWithSubQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
        {
            _categoryReadRepository = categoryReadRepository;
            _mapper = mapper;
        }

        public async Task<GetCategoriesWithSubQueryResponse> Handle(GetCategoriesWithSubQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetCategoriesWithSubQueryResponse
            {
                IsSuccess = true,
                Data = _mapper.Map<List<GetCategoriesDto>>(_categoryReadRepository.GetAll().Include(x => x.SubCategories).ToList().Where(x => x.ParentId == null)),
                Message = null
            };
        }


    }
}