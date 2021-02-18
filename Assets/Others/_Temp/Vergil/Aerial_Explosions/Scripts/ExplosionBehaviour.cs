using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour
{
    public AudioSource ExplodeAudio;
    public ParticleSystem SparkParticles;
    public ParticleSystem SparkTrailsParticles;
    public ParticleSystem ExplodeVideoParticles;

    // Update is called once per frame
    void Update()
    {
        ExplodeVideoParticles.Clear();
        SparkParticles.Clear();
        SparkTrailsParticles.Clear();
        Explosion();
    }

    void Explosion()
    {
        ExplodeVideoParticles.Play();
        SparkParticles.Play();
        SparkTrailsParticles.Play();
        ExplodeAudio.Play();

    }
}
