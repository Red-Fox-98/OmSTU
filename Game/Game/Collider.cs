using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Collider
    {
        Transform transform;
        List<Collider> colliders;
        float radius;

        public Collider(Transform transform, List<Collider> colliders, float radius)
        {
            this.radius = radius;
            this.colliders = colliders;
            this.transform = transform;
            colliders.Add(this);
        }

        public bool CollisionCheck()
        {
            foreach (var collider in colliders)
            {
                if (collider == this)
                {
                    continue;
                }
                float distance =
                        MathF.Sqrt(
                        (float)Math.Pow((double)collider.transform.position.x - (double)transform.position.x, 2.0) +
                        (float)Math.Pow((double)collider.transform.position.y - (double)transform.position.y, 2.0)
                    );
                if (distance > collider.radius + radius)
                {
                    continue;
                }
                return true;
            }
            return false;
        }
    }
}