# TMP MASTER

# Git
$ git init
$ git add .

$ git config --global user.email "you@example.com"
$ git config --global user.name "Your Name"

$ git commit -m "init"

$ git branch -M master
$ git remote add origin https://github.com/dbulan/2025-it-notes.git

$ git push -u origin master
// remote: Invalid username or password.
// fatal: Authentication failed for 'https://github.com/dbulan/2025-it-notes.git/'
Settings > Developer Settings > Personal Access Tokens > Tokens (classic).

$ git push -u origin master // appear modal window with credentials