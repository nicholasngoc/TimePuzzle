using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Adds the ability for the player to slow or accelerate time.
/// Author: Alben Trang
/// </summary>
public class PlayerSlowAndAccelerate : MonoBehaviour
{
    public FirstPersonAIO playerMovement;

    private float originalWalkSpeed;
    private float fixedDeltaTime;

    /// <summary>
    /// Store the default fixed delta time that's 0.02f at the start of the scene.
    /// </summary>
    private void Awake()
    {
        originalWalkSpeed = playerMovement.walkSpeed;
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    /// <summary>
    /// Check at the end of every frame for the player to change the time scale.
    /// </summary>
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ChangeTimeScale(0.5f);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeTimeScale(2.0f);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            ChangeTimeScale(1.0f);
        }
    }

    /// <summary>
    /// Changes the time scale to slow or accelerate the scene.
    /// </summary>
    /// <param name="newTimeScale">The new time scale number.</param>
    private void ChangeTimeScale(float newTimeScale)
    {
        Time.timeScale = newTimeScale;
        // This changes physics differently.
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        // This is used to keep the player's speed constant no matter how slow or fast the environment is.
        playerMovement.walkSpeed = originalWalkSpeed / newTimeScale;
    }
}
