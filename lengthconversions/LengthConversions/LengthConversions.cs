using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConversions
{
    /**********************************************************************/
    /*****  Class: LengthConversions                                  *****/                                                             
    /*****  Dev:   Tim Schultz                                        *****/                      
    /*****  Date:  11/05/2018                                         *****/                     
    /*****  Description: Methods for length and distance conversions  *****/                                                           
    /**********************************************************************/
    public class LengthConversions
    {
        public const double KM_PER_IN       = 0.0000254d;
        public const double M_PER_IN        = 0.0254d;
        public const double DM_PER_IN       = 0.254d;
        public const double CM_PER_IN       = 2.54d;
        public const double MM_PER_IN       = 25.4d;
        public const double IN_PER_FT       = 12d;
        public const double MM_PER_FT       = 304.8d;
        public const double CM_PER_FT       = 30.48d;
        public const double DM_PER_FT       = 3.048d;
        public const double M_PER_FT        = 0.3048d;
        public const double KM_PER_FT       = 0.0003048d;
        public const double FT_PER_YD       = 3d;
        public const double IN_PER_YD       = 36d;
        public const double MM_PER_YD       = 914.4d;
        public const double CM_PER_YD       = 91.44d;
        public const double DM_PER_YD       = 9.144d;
        public const double M_PER_YD        = 0.9144d;
        public const double KM_PER_YD       = 0.000914d;
        public const double YD_PER_MI       = 1760d;
        public const double FT_PER_MI       = 5280d;
        public const double IN_PER_MI       = 63360d;
        public const double MM_PER_MI       = 1609344d;
        public const double CM_PER_MI       = 160934.4d;
        public const double DM_PER_MI       = 16093.44d;
        public const double M_PER_MI        = 1609.344d;
        public const double KM_PER_MI       = 1.609344d;
        public const double MM_PER_CM       = 10d;
        public const double MM_PER_DM       = 100d;
        public const double MM_PER_M        = 1000d;
        public const double MM_PER_KM       = 1000000d;
        public const double CM_PER_DM       = 10d;
        public const double CM_PER_M        = 100d;
        public const double CM_PER_KM       = 100000d;
        public const double DM_PER_M        = 10d;
        public const double DM_PER_KM       = 10000d;
        public const double M_PER_KM        = 1000d;

        public static void Main(string[] args)
        {
            Console.WriteLine(Convert_FT_To_M(29029, 2));
            Console.ReadLine();
        }

        /// <summary>
        /// Convert inches to millimeters
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_MM(double inch, int decimals)
        {
            return Math.Round(inch * MM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert inches to centimeters
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_CM(double inch, int decimals)
        {
            return Math.Round(inch * CM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert inches to decimeters
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_DM(double inch, int decimals)
        {
            return Math.Round(inch * DM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert inches to meters
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_M(double inch, int decimals)
        {
            return Math.Round(inch * M_PER_IN, decimals);
        }

        /// <summary>
        /// Convert inches to kilometers
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_KM(double inch, int decimals)
        {
            return Math.Round(inch * KM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert inches to feet
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_FT(double inch, int decimals)
        {
            return Math.Round(inch / IN_PER_FT, decimals);
        }

        /// <summary>
        /// Convert inches to yards
        /// </summary>
        /// <param name="inches"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_YD(double inches, int decimals)
        {
            return Math.Round(inches / IN_PER_YD, decimals);
        }

        /// <summary>
        /// Convert inches to miles
        /// </summary>
        /// <param name="inch"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_IN_To_MI(double inch, int decimals)
        {
            return Math.Round(inch / IN_PER_MI, decimals);
        }

        /// <summary>
        /// Convert feet to millimeters
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_MM(double ft, int decimals)
        {
            return Math.Round(ft * MM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert feet to centimeters
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_CM(double ft, int decimals)
        {
            return Math.Round(ft * CM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert feet to decimeters
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_DM(double ft, int decimals)
        {
            return Math.Round(ft * DM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert feet to meters
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_M(double ft, int decimals)
        {
            return Math.Round(ft * M_PER_FT, decimals);
        }

        /// <summary>
        /// Convert feet to kilometers
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_KM(double ft, int decimals)
        {
            return Math.Round(ft * KM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert feet to inches
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_IN(double ft, int decimals)
        {
            return Math.Round(ft * IN_PER_FT, decimals);
        }

        /// <summary>
        /// Convert feet to yards
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_YD(double ft, int decimals)
        {
            return Math.Round(ft / FT_PER_YD, decimals);
        }

        /// <summary>
        /// Convert feet to miles
        /// </summary>
        /// <param name="ft"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_FT_To_MI(double ft, int decimals)
        {
            return Math.Round(ft / FT_PER_MI, decimals);
        }

        /// <summary>
        /// Convert yards to millimeters
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_MM(double yd, int decimals)
        {
            return Math.Round(yd * MM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to centimeters
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_CM(double yd, int decimals)
        {
            return Math.Round(yd * CM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to decimeters
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_DM(double yd, int decimals)
        {
            return Math.Round(yd * DM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to meters
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_M(double yd, int decimals)
        {
            return Math.Round(yd * M_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to kilometers
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_KM(double yd, int decimals)
        {
            return Math.Round(yd * KM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to inches
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_IN(double yd, int decimals)
        {
            return Math.Round(yd * IN_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to feet
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_FT(double yd, int decimals)
        {
            return Math.Round(yd * FT_PER_YD, decimals);
        }

        /// <summary>
        /// Convert yards to miles
        /// </summary>
        /// <param name="yd"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_YD_To_MI(double yd, int decimals)
        {
            return Math.Round(yd / YD_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to millimeters
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_MM(double miles, int decimals)
        {
            return Math.Round(miles * MM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to centimeters
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_CM(double miles, int decimals)
        {
            return Math.Round(miles * MM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to decimeters
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_DM(double miles, int decimals)
        {
            return Math.Round(miles * DM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to meters
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_M(double miles, int decimals)
        {
            return Math.Round(miles * M_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to kilometers
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_KM(double miles, int decimals)
        {
            return Math.Round(miles * KM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to inches
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_IN(double miles, int decimals)
        {
            return Math.Round(miles * IN_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to feet
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_FT(double miles, int decimals)
        {
            return Math.Round(miles * FT_PER_MI, decimals);
        }

        /// <summary>
        /// Convert miles to yards
        /// </summary>
        /// <param name="miles"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MI_To_YD(double miles, int decimals)
        {
            return Math.Round(miles * YD_PER_MI, decimals);
        }

        /// <summary>
        /// Convert millimeters to centimeters
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MM_To_CM(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_CM, decimals);
        }

        /// <summary>
        /// Convert millimeters to decimeters
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static double Convert_MM_To_DM(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_DM, decimals);
        }

        /// <summary>
        /// Convert millimeters to meters
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static double Convert_MM_To_M(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_M, decimals);
        }

        /// <summary>
        /// Convert millimeters to kilometers
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static double Convert_MM_To_KM(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_KM, decimals);
        }

        /// <summary>
        /// Convert millimeters to inches
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MM_To_IN(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert millimeters to feet
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MM_To_FT(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert millimeters to yards
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MM_To_YD(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert millimeters to miles
        /// </summary>
        /// <param name="mm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_MM_To_MI(double mm, int decimals)
        {
            return Math.Round(mm / MM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert centimeters to millimeters
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_MM(double cm, int decimals)
        {
            return Math.Round(cm * MM_PER_CM, decimals);
        }

        /// <summary>
        /// Convert centimeters to decimeters
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_DM(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_DM, decimals);
        }

        /// <summary>
        /// Convert centimeters to meters
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_M(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_M, decimals);
        }

        /// <summary>
        /// Convert centimeters to kilometers
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_KM(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_KM, decimals);
        }

        /// <summary>
        /// Convert centimeters to inches
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_IN(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert centimeters to feet
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_FT(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert centimeters to yards
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_YD(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert centimeters to miles
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_CM_To_MI(double cm, int decimals)
        {
            return Math.Round(cm / CM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert decimeters to millimeters
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_MM(double dm, int decimals)
        {
            return Math.Round(dm * MM_PER_DM, decimals);
        }

        /// <summary>
        /// Convert decimeters to centimeters
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_CM(double dm, int decimals)
        {
            return Math.Round(dm * CM_PER_DM, decimals);
        }

        /// <summary>
        /// Convert decimeters to meters
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_M(double dm, int decimals)
        {
            return Math.Round(dm / DM_PER_M, decimals);
        }

        /// <summary>
        /// Convert decimeters to kilolmeters
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_KM(double dm, int decimals)
        {
            return Math.Round(dm / DM_PER_KM, decimals);
        }

        /// <summary>
        /// Convert decimeters to inches
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_IN(double dm, int decimals)
        {
            return Math.Round(dm / DM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert decimeters to feet
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_FT(double dm, int decimals)
        {
            return Math.Round(dm / DM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert decimeters to yards
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_YD(double dm, int decimals)
        {
            return Math.Round(dm / DM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert decimeters to miles
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_DM_To_MI(double dm, int decimals)
        {
            return Math.Round(dm / DM_PER_MI, decimals);
        }

        /// <summary>
        /// Convert meters to millimeters
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_MM(double m, int decimals)
        {
            return Math.Round(m * MM_PER_M, decimals);
        }

        /// <summary>
        /// Convert meters to centimeters
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_CM(double m, int decimals)
        {
            return Math.Round(m * CM_PER_M, decimals);
        }

        /// <summary>
        /// Convert meters to decimeters
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_DM(double m, int decimals)
        {
            return Math.Round(m * DM_PER_M, decimals);
        }

        /// <summary>
        /// Convert meters to kilometers
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_KM(double m, int decimals)
        {
            return Math.Round(m / M_PER_KM, decimals);
        }

        /// <summary>
        /// Convert meters to inches
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_IN(double m, int decimals)
        {
            return Math.Round(m / M_PER_IN, decimals);
        }

        /// <summary>
        /// Convert meters to feet
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_FT(double m, int decimals)
        {
            return Math.Round(m / M_PER_FT, decimals);
        }

        /// <summary>
        /// Convert meters to yards
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_YD(double m, int decimals)
        {
            return Math.Round(m / M_PER_YD, decimals);
        }

        /// <summary>
        /// Convert meters to miles
        /// </summary>
        /// <param name="m"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_M_To_MI(double m, int decimals)
        {
            return Math.Round(m / M_PER_MI, decimals);
        }

        /// <summary>
        /// Convert kilometers to millimeters
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_MM(double km, int decimals)
        {
            return Math.Round(km * MM_PER_KM, decimals);
        }

        /// <summary>
        /// Convert kilometers to centimeters
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_CM(double km, int decimals)
        {
            return Math.Round(km * CM_PER_KM, decimals);
        }

        /// <summary>
        /// Convert kilometers to decimeters
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_DM(double km, int decimals)
        {
            return Math.Round(km * DM_PER_KM, decimals);
        }

        /// <summary>
        /// Convert kilometers to meters
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_M(double km, int decimals)
        {
            return Math.Round(km * M_PER_KM, decimals);
        }

        /// <summary>
        /// Convert kilometers to inches
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_IN(double km, int decimals)
        {
            return Math.Round(km / KM_PER_IN, decimals);
        }

        /// <summary>
        /// Convert kilometers to feet
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_FT(double km, int decimals)
        {
            return Math.Round(km / KM_PER_FT, decimals);
        }

        /// <summary>
        /// Convert kilometers to yards
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_YD(double km, int decimals)
        {
            return Math.Round(km / KM_PER_YD, decimals);
        }

        /// <summary>
        /// Convert kilometers to miles
        /// </summary>
        /// <param name="km"></param>
        /// <param name="decimals"></param>
        /// <returns>double</returns>
        public static double Convert_KM_To_MI(double km, int decimals)
        {
            return Math.Round(km / KM_PER_MI, decimals);
        }
    }
}
