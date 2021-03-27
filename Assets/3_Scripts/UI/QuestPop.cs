using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPop : MonoBehaviour
{
    public Canvas quests;
    public GameObject questPanel;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = questPanel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Quests.enemyCount == 50 && Quests.enemyCount < 51)
        {
            PlayAnimationText();
        }
        if (Quests.killedBoss == true && Quests.playedBoss == false)
        {
            PlayAnimationText();
        }
        if (Quests.placedTurrets >= 10 && Quests.playedTurrets == false)
        {
            PlayAnimationText();
        }
    }

    public void PopQuestText()
    {
        if(questPanel != null)
        {

            if(animator != null)
            {
                bool isPlay = animator.GetBool("play");
                animator.SetBool("play", !isPlay);
            }
        }
    }

    private IEnumerator WaitForAnimation()
    {
        animator.SetBool("play", true);
        yield return new WaitForSeconds(3);
        animator.SetBool("play", false);
    }
    public void PlayAnimationText()
    {
        StartCoroutine(WaitForAnimation());
    }
}
