# apbd-cw1-git-s33587
## Tutorial 1 - Git and GitHub
> Repository work, change history, branches, merge, rebase, and conflicts

### Questions
1. When does Git perform a fast-forward and when is a merge commit created?
    - A fast-forward is performed if the feature branch and the target branch haven't diverged;
    If a merge is fast-forward, no merge commit is created.
2. What is the practical difference between merge and rebase?
    - Git merge incorporates changes from a feature branch into the current branch;
    if there's no conflict, a fast-forward is performed (as mentioned above);
    the conflicts needs to be resolved otherwise.
    - Git rebase changes the starting point of a branch, which allows to perform a fast-forward merge,
   but the operation doesn't merge the branches by itself.
3. How was the conflict resolved in your repository?
    - To resolve the conflict, the version from `main` was accepted over the `feature-conflict` one.
    The merge conflict was resolved via Rider.