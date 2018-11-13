using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interpol
{
    public class PhotoModel
    {
        public static readonly int NotDefinedInt = -1;
        public static readonly string NotDefinedString = "";
        public static readonly Color NotDefinedColor = new Color();
        public static readonly DateTime NotDefinedDateTime = new DateTime();

        private DateTime birth;

        public PhotoModel(
            int height, Color hairColor, Color eyeColor,
            string description, string motherland, DateTime birth)
        {
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Description = description;
            Motherland = motherland;
            this.birth = birth;
        }

        public PhotoModel(PhotoModel copyPhotoModel) : 
            this (copyPhotoModel.Height, copyPhotoModel.HairColor,
                  copyPhotoModel.EyeColor, copyPhotoModel.Description,
                  copyPhotoModel.Motherland, copyPhotoModel.Birth)
        {

        }

        public int Height { get; private set; }
        public Color HairColor { get; private set; }
        public Color EyeColor { get; private set; }
        public string Description { get; private set; }
        public string Motherland { get; private set; }
        public DateTime Birth { get { return new DateTime(birth.Year, birth.Month, birth.Day); } }

        public override bool Equals(object obj)
        {
            if (!obj.GetType().Equals(typeof(PhotoModel)))
                return false;

            PhotoModel temp = obj as PhotoModel;
            return (temp.Height == Height || temp.Height == NotDefinedInt) &&
                   (temp.HairColor == HairColor || temp.HairColor.Equals(NotDefinedColor)) &&
                   (temp.EyeColor == EyeColor || temp.EyeColor.Equals(NotDefinedColor)) &&
                   (temp.Description == Description || temp.Description == NotDefinedString) &&
                   (temp.Motherland == Motherland || temp.Motherland == NotDefinedString) &&
                   ((temp.birth.Year == birth.Year && temp.birth.Month == birth.Month &&
                   temp.birth.Day == birth.Day) || (temp.birth.Year == NotDefinedDateTime.Year &&
                   temp.birth.Month == NotDefinedDateTime.Month &&
                   temp.birth.Day == NotDefinedDateTime.Day));
        }

        public override string ToString()
        {
            return Height + ";" + HairColor.R + ";" + HairColor.G + ";" + HairColor.B + ";"
                                + EyeColor.R + ";" + EyeColor.G + ";" + EyeColor.B + ";"
                                + Description + ";" + Motherland + ";" + birth.Year + ";"
                                + birth.Month + ";" + birth.Day;
        }
    }
}
