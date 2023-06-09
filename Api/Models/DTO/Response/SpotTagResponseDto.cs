﻿using Api.Data;
using Api.Models.Entities;

namespace Api.Models.DTO.Response
{
    public class SpotTagResponseDto
    {

        public int Id { get; set; }
        public int SpotId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagDescription { get; set; }
        
        public SpotTagResponseDto(SpotTag spotTag) 
        {
            Id = spotTag.Id;
            SpotId = spotTag.SpotId;
            TagId = spotTag.TagId;
            TagName = spotTag.Tag.Name;
            TagDescription = spotTag.Tag.Description;
        }

        public static IEnumerable<SpotTagResponseDto> CreateResponse(List<SpotTag> spotTags)
        {
            foreach (var spotTag in spotTags)
            {
                yield return new SpotTagResponseDto(spotTag);
            }
        }
    }
}
