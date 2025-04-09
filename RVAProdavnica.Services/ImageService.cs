using AutoMapper;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;

namespace RVAProdavnica.Services
{
    public interface IImageService
    {
        ImageModel getById(int id);

        List<ImageModel> GetAll();

    }

    public class ImageSrvice : IImageService
    {
        private readonly IImageRepository imageRepository;
        
        private readonly IMapper mapper;
        
        public ImageSrvice(IImageRepository imageRepository, IMapper mapper)
        {
            this.imageRepository = imageRepository;
            this.mapper = mapper;
        }

        public ImageModel getById(int id)
        {
            return mapper.Map<ImageModel>(imageRepository.GetOne(id));
        }

        public List<ImageModel> GetAll()
        {
            var resultFromDb = imageRepository.GetAll();
            var resultModels = mapper.Map<List<ImageModel>>(resultFromDb);
            return resultModels;            
        }

    }
}