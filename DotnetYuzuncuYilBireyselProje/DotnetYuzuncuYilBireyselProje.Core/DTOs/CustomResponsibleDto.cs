using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Core.DTOs
{
    public class CustomResponsibleDto<T>
    {
        public T Data { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
        public static CustomResponsibleDto<T> Success(int statusCode, T data)
        {
            return new CustomResponsibleDto<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomResponsibleDto<T> Success(int statusCode)
        {
            return new CustomResponsibleDto<T> { StatusCode = statusCode };
        }
        public static CustomResponsibleDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponsibleDto<T> { StatusCode = statusCode, Errors = errors };
        }
        public static CustomResponsibleDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponsibleDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }

    }
}
