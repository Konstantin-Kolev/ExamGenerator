namespace ExamGenerator.Services.Mapping
{
    public static class MappingExtensions
    {
        public static Destination To<Destination>(this object source) => AutoMapperConfig.MapperInstance.Map<Destination>(source);
    }
}
