/*
 * Index Card API
 *
 * This is a simple server for loading and saving index cards
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Models.DTOs
{
    /// <summary>
    /// Model for User
    /// </summary>
    [DataContract]
    public partial class UserInputDTO : IEquatable<UserInputDTO>
    {
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>

        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceLevel
        /// </summary>

        [DataMember(Name = "experienceLevel")]
        public int? ExperienceLevel { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>

        [DataMember(Name = "points")]
        public int? Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  ExperienceLevel: ").Append(ExperienceLevel).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((UserInputDTO)obj);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInputDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) &&
                (
                    ExperienceLevel == other.ExperienceLevel ||
                    ExperienceLevel != null &&
                    ExperienceLevel.Equals(other.ExperienceLevel)
                ) &&
                (
                    Points == other.Points ||
                    Points != null &&
                    Points.Equals(other.Points)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                if (ExperienceLevel != null)
                    hashCode = hashCode * 59 + ExperienceLevel.GetHashCode();
                if (Points != null)
                    hashCode = hashCode * 59 + Points.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UserInputDTO left, UserInputDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserInputDTO left, UserInputDTO right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
