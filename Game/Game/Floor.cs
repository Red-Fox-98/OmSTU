using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Floor
    {
        Avatar image;
        Collider collider;
        Transform transform;
        public Floor(int x, int y, Avatar image,List<Collider> colliders)
        {
            transform = new Transform(x, y);
            this.image = image;
            collider = new Collider(new Vector(0, 0), new Vector(3, 2), transform, colliders);
        }

        public void Update()
        {
            image.Draw((int)transform.position.x, (int)transform.position.y);
        }
    }
}