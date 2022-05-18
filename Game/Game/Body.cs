using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Body
    {
        Transform transform;
        Vector velocity;
        float mass;
        
        public Body(Transform transform, Vector startVelocity, float mass)
        {
            this.transform = transform;
            this.velocity = startVelocity;
            this.mass = mass;
        }

        public void AddVelocity(Vector vector)
        {
            this.velocity += vector / mass;
        }

        public void Update()
        {
            AddVelocity(new Vector(0, 0.01f) * mass);
            transform.position += this.velocity;
        }
    }
}