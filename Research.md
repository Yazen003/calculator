git squash:
 لو كان عندي feature وبعد كل تعديل بعمل commit  ممكن اجمعهم كلهم ب commit  واحد

git merge vs git rebase:

ال merge ببين ال history كامل بدون اي  تعديل ولكن في حال كان ال main branch بيحصل عليه كثير commits  من برانشز مختلفة او  على ال main  branch يصير commits كثير ف راح يأثر على ال history for feature branch طريقة عمله انه بتم اضافة كوميت بجمع ال feature and main ,على الجهة الاخرى rebase  ما بضيف كوميت جديد هو بنقل	حافة feature branch  وبحطها على ال main ببين ال history like linear line مثلا متى التعديلات حدثت على ال feature . لكن يخفي

git --help :

ممكن استفيد منها عشان اعرف اي command  بحتاج استخدم في ال case  اللي انا فيها برضه بضيف شرح تفصيلي ل command  معين 


git cherry-pick : 
تستخدم لنسخ commits ونقل النسخة ل branch  اخر  زي في حالة ال hotfixes مثلا


git clean : 
 بتعمل مسح لل  untracked files 

git grep : 
يستخدم في البحث عن محتوى بوخذه من المطور وببجث عنه داخل ال tracked files 

git blame : 
باختصار، يوضح  git blame بالضبط من قام بتغيير كل سطر من الملف اخر مرة، ومتى، وفي أي commit 

git bisect : 
تستخدم ببساطة لما يكون عندي مثلا bug  بدي اصلحها وبكون عندي كثير commits صارت بعد هذا ال commit  اللي بحتوي عليها بالتالي  ال  bisect بستخدم خوارزمية BSA بحيث مثلا يقسم ال commits وبناء على ادخال inputs من طرف المطور "good or bad " بيوجد ال commit اللي بحتوي bug (used for debugging)

git shortlog:
هي نسخة مختصرة من git log بتعمل ملخص لل commit history من خلال تجميع ال commits لكل  author  لحال , ف بقدر اشوف من خلالها كل مطور شو عمل وشو اللي اشتغل عليه .

git prune:
 هو التخلص الداخلي من ال garbage في Git.  بحذف البيانات  اللي لا يمكن الوصول لها بشكل دائم في الlocal repo  لتقليل المساحة في الديسك.

git worktree :
بسمحلك تشوف اكثر من branch بنفس الوقت في folders مختلفة , كلها مربوطة في ال local repo 

git verify-commit:
(security command ) يستخدم للتحقق من الcryptographic signature ، مما يثبت أن تم إجراؤه بالفعل من قبل الشخص الذي يدعي أنه قام به.

git filter-repo:

 أداة قوية تستخدم لإعادة كتابة ال repo history بالكامل و بشكل دائم.









