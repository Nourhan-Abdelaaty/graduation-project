﻿using System.ComponentModel.DataAnnotations;

namespace GraduateProject.httpModels.requests;

//NjM3ODgwMDU3MjI5MzRhbGllbG1vcnN5NzFzRWQ=
public class UploadImageModel
{
    [Required] [DataType(DataType.Upload)] public IFormFile Image { get; set; }

    public String SessionToken { get; set; }
}