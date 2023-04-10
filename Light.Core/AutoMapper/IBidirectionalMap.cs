using AutoMapper;

namespace Light.Core.AutoMapper
{
    public interface IBidirectionalMap<T>
    {
        void CreateMap(Profile profile)
            => profile.CreateMap(GetType(), typeof(T)).ReverseMap();
    }
}
