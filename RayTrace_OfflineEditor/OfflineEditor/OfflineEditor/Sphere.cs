using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineEditor
{
    class Sphere
    {
        public Vec3f Center;
        public Vec3f Velocity;
        public float Radius;
        public Vec3f SurfaceColor, EmissionColor;
        public float Transparency, Reflection;
        public float RadiusIncrement;

        public Sphere(  Vec3f surfaceColor = default , Vec3f center = default, Vec3f velocity = default, Vec3f emissionColor = default,
            float radius = 0.0f, float transparency = 0.0f, float reflection = 0.0f, float radiusIncrement = 0.0f) 
        {
            Center = center;
            Velocity = velocity;
            Radius = radius;
            SurfaceColor = surfaceColor;
            EmissionColor = emissionColor;
            Transparency = transparency;
            Reflection = reflection;
            RadiusIncrement = radiusIncrement;
        }
    }
}
