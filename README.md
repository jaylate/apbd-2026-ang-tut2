# apbd-2026-ang-tut2

## Task 5 - Merge without fast-forward
The merge which follows the commit which modifies the README will not allow fast forwarding, as both branches have changes and this influences history.

## Task 6 - Merge vs rebase
Merging creates a new commit that incorporates changes from different branches, which can lead to unnecessary merge commits in the history. In contrast, rebasing rewrites the commit history by moving commits from one branch onto another, maintaining a linear history. However, rebasing can alter commit hashes, which may cause conflicts if others are working with the same commits.

## Task 7 - Resolving conflict
I modified one line in both branches, `git rebase feature-conflict` produced an error that rebasing failed.
I removed the markers in the file changed, including only one change, added the file and ran `git rebase --continue` which succesfully finished the process.
Different way to address the same issue is to use `git rebase -i` and choose the commit which should remain by choosing it with `pick` in the interactive interface.
