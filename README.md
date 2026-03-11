# apbd-2026-ang-tut2

## Task 5 - Merge without fast-forward
The merge which follows the commit which modifies the README will not allow fast forwarding, as both branches have changes and this influences history.

## Task 6 - Merge vs rebase
Merging creates a new commit that incorporates changes from different branches, which can lead to unnecessary merge commits in the history. In contrast, rebasing rewrites the commit history by moving commits from one branch onto another, maintaining a linear history. However, rebasing can alter commit hashes, which may cause conflicts if others are working with the same commits.
