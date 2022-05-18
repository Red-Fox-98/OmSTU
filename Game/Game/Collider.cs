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
        Vector topLeftCorner;
        Vector bottomRightCorner;

        public Collider(Vector topLeftCorner, Vector bottomRightCorner, Transform transform, List<Collider> colliders)
        {
            this.topLeftCorner = topLeftCorner;
            this.bottomRightCorner = bottomRightCorner;
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

                if (bottomRightCorner.y + transform.position.y < collider.topLeftCorner.y + collider.transform.position.y ||
                    collider.bottomRightCorner.y + collider.transform.position.y < topLeftCorner.y + transform.position.y
                )
                {
                    continue;
                }


                if (bottomRightCorner.x + transform.position.x < collider.topLeftCorner.x + collider.transform.position.x ||
                    collider.bottomRightCorner.x + collider.transform.position.x < topLeftCorner.x + transform.position.x
                )
                {
                    continue;
                }



                return true;
            }
            return false;
        }
    }
}