using System.Text.Json.Serialization;
using System.Text.Json;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;

namespace HelpWanted.Models
{
    public class Project
    {
        [BsonId]
        public Guid id {get; set;}
        
        [JsonPropertyName("user")]
        public string Name {get; set;}
        
        [JsonPropertyName("projName")]
        public string ProjectName {get; set;}
        
        [JsonPropertyName("projDesc")]
        public string ProjectDescription {get; set;}
        
        [JsonPropertyName("helpType")]
        public Enums.HelpTypes HelpType {get; set;}
        
        [JsonPropertyName("helpWanted")]
        public string HelpWanted {get; set;}

        [JsonPropertyName("helpSkills")]
        public string[] HelpSkills {get; set;}

        [JsonPropertyName("teamMembers")] 
        public string[] TeamMembers {get; set;}

        [JsonPropertyName("percentFinished")]
        public Enums.Progress Progress {get; set;}

        [JsonPropertyName("contactInfo")]
        public string ContactInformation {get; set;}

        public Project()
        {

        }


        public Project(string name, string projectName, string projectDescription, string helpWanted, string[] helpSkills, Enums.HelpTypes helpType, string[] teamMembers, Enums.Progress progress, string contactInfo)
        {
            Name = name;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            HelpWanted = helpWanted;
            HelpType = helpType;
            TeamMembers = teamMembers;
            Progress = progress;
            ContactInformation = contactInfo;
            HelpSkills = helpSkills;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Project>(this);
        }
    }
}