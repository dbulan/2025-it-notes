# GIT-INIT

$ git init

$ git config --global user.email "you@example.com"
$ git config --global user.name "Your Name"

$ git commit -m "init"

// remote branch
$ git branch -M master
$ git remote add origin https://github.com/dbulan/2025-it-notes.git

$ git push -u origin master

# Remote Password
// remote: Invalid username or password.
// fatal: Authentication failed for 'https://github.com/dbulan/2025-it-notes.git/'
Settings > Developer Settings > Personal Access Tokens > Tokens (classic).

$ git push -u origin master // appears modal window with credentials