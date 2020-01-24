using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestMultiShot
    {
        [UnityTest]
        public IEnumerator TestMultiShot1()
        {
            Vector3 startPostion = new Vector3(0, 0, 0);
            float rotation = 0;
            Vector3 vectorOne = new Vector3(1, 0, 0);
            Vector3 vectorTwo = new Vector3(2, 0, 0);
            float desiredResult = 1.0f;

            Vector3 resultOne = FireBullet.VectorRotation(startPostion, rotation, vectorOne);
            Vector3 resultTwo = FireBullet.VectorRotation(startPostion, rotation, vectorTwo);
            float result = Vector3.Distance(resultOne, resultTwo);

            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator TestMultiShot2()
        {
            Vector3 startPostion = new Vector3(0, 0, 0);
            float rotation = 77;
            Vector3 vectorOne = new Vector3(1, 0, 0);
            Vector3 vectorTwo = new Vector3(2, 0, 0);
            float desiredResult = 1.0f;

            Vector3 resultOne = FireBullet.VectorRotation(startPostion, rotation, vectorOne);
            Vector3 resultTwo = FireBullet.VectorRotation(startPostion, rotation, vectorTwo);
            float result = Vector3.Distance(resultOne, resultTwo);
            float temp = Mathf.Ceil(result);
            if (result - temp > 0.999)
            {
                result = temp + 1;
            }
            else if (result - temp < 0.001)
            {
                result = temp;
            }
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator TestMultiShot3()
        {
            Vector3 startPostion = new Vector3(2, -3, 0);
            float rotation = 0;
            Vector3 vectorOne = new Vector3(1, 0, 0);
            Vector3 vectorTwo = new Vector3(2, 0, 0);
            float desiredResult = 1.0f;

            Vector3 resultOne = FireBullet.VectorRotation(startPostion, rotation, vectorOne);
            Vector3 resultTwo = FireBullet.VectorRotation(startPostion, rotation, vectorTwo);
            float result = Vector3.Distance(resultOne, resultTwo);
            
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator TestMultiShot4()
        {
            Vector3 startPostion = new Vector3(0, 0, 0);
            float rotation = 0;
            Vector3 vectorOne = new Vector3(3, 0, 0);
            Vector3 vectorTwo = new Vector3(0, 4, 0);
            float desiredResult = 5.0f;

            Vector3 resultOne = FireBullet.VectorRotation(startPostion, rotation, vectorOne);
            Vector3 resultTwo = FireBullet.VectorRotation(startPostion, rotation, vectorTwo);
            float result = Vector3.Distance(resultOne, resultTwo);

            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
    }
}
