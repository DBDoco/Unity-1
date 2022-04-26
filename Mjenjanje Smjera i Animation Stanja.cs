    [SerializeField] public Animator animator;

	void Update()
    {
        if (horizontalAxis < 0) transform.localRotation = Quaternion.Euler(0, 180, 0);
        else if (horizontalAxis > 0) transform.localRotation = Quaternion.Euler(0, 0, 0);
        animator.SetBool("running", horizontalAxis != 0);

    }