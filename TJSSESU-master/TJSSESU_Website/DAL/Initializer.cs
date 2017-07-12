using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TJSSESU_Website.Models;

namespace TJSSESU_Website.DAL
{
	public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WebsiteContext>
	{
        protected override void Seed(WebsiteContext context)
        {
            var departments = new List<Department>
            {
                new Department{deptName="组织部",capacity=8,introduction="一起搞事情啦"},
                new Department{deptName="学术部", capacity=6,introduction="一只棒棒哒"},
                new Department{deptName="文艺部",capacity=7,introduction="李波最帅！"},
                new Department{deptName="外联部",capacity=9,introduction="可菲你最棒"},
                new Department{deptName="宣传部",capacity=10,introduction="制作视频最开心"},
                new Department{deptName="体育部",capacity=6,introduction="灰少"},
                new Department{deptName="秘书处",capacity=4,introduction="勤奋的孩子"},
                new Department{deptName="主席团",capacity=4,introduction="来搞事情！"}
            };
            departments.ForEach(s => context.departments.Add(s));
            context.SaveChanges();
            var positions = new List<Position>
            {
                new Position{posName="干事",Sclass=1},
                new Position{posName="副部长",Sclass=2},
                new Position{posName="部长",Sclass=3},
                new Position{posName="副主席",Sclass=4},
                new Position{posName="主席助理",Sclass=5},
                new Position{posName="主席",Sclass=6}
            };
            positions.ForEach(s => context.positions.Add(s));
            context.SaveChanges();
            var users = new List<User>
            {
                new User { SID="1552635",name="胡嘉鑫",password="hjx202020202",deptName="组织部",posName="干事"},
                new User { SID="1552632",name="陈湃轩", password="cpxadmin",deptName="宣传部",posName="副部长"},
                new User { SID="1552607",name = "吕岩松",password="lvs12112321",deptName="文艺部",posName="部长"}
            };
            users.ForEach(s => context.users.Add(s));
            context.SaveChanges();
            var news = new List<News>
            {
                new News {newsID = 1,publishDate=new DateTime(2016,5,28),newsTitle="我们的项目",context="aaaaaaaaaaaaaaaaaaaaaaa",pictureUrl=null,SID="1552635"},
                new News {newsID=2,publishDate=new DateTime(2017,7,2),newsTitle="lalala",context="bbbbbbbbbbbbbb",pictureUrl=null,SID="1552632"}
            };
            var admins = new List<Admin>
            {
                new Admin{adminID="12",passWord="1559256"}
            };
            admins.ForEach(s => context.admins.Add(s));
            news.ForEach(s => context.news.Add(s));
            context.SaveChanges();
            var details = new List<Detail>
            {
                new Detail {SID="1552635",personal_introduction="hhhhhhh",sClass=1,age=20,birthDate=new DateTime(1996,12,26),nameOfBirth="Shanxi",email="470348052@qq.com",phoneNumber="18101917663"}
            };
            details.ForEach(s => context.details.Add(s));
            context.SaveChanges();
            var tasks = new List<Task>
            {
                new Task {taskID=1,taskTitle="第一个任务",introduction="你说呢",publishDate=new DateTime(1996,11,24),deadlineDate=new DateTime(1997,11,24),tag="迎新晚会",executeStatement=1,SID="1552632"},
                new Task {taskID=2,taskTitle="第二个任务",introduction="你说呢2",publishDate=new DateTime(1996,12,24),deadlineDate=new DateTime(1998,10,24),tag="迎新晚会第二年",executeStatement=0,SID="1552632"},
                new Task {taskID=3,taskTitle="第三个任务",introduction="你说呢3",publishDate=new DateTime(2005,3,15),deadlineDate=new DateTime(2018,11,24),tag="迎新晚会",executeStatement=2,SID="1552607"},
                new Task {taskID=4,taskTitle="第四个任务",introduction="你说呢IV",publishDate=new DateTime(1999,11,24),deadlineDate=new DateTime(2002,3,5),tag="迎新晚会第二年",executeStatement=1,SID="1552607"},
                new Task {taskID=5,taskTitle="第五个任务",introduction="你说呢FIVE",publishDate=new DateTime(1999,11,24),deadlineDate=new DateTime(2002,3,5),tag="迎新晚会",executeStatement=1,SID="1552607"},
            };
            tasks.ForEach(s => context.tasks.Add(s));
            context.SaveChanges();
            var executeTasks = new List<ExecuteTask>
            {
                new ExecuteTask{taskID=1,SID="1552635",executeStatement=1},
                new ExecuteTask{taskID=2,SID="1552635",executeStatement=0},
                new ExecuteTask{taskID=3,SID="1552635",executeStatement=1},
                new ExecuteTask{taskID=3,SID="1552632",executeStatement=2},
                new ExecuteTask{taskID=4,SID="1552632",executeStatement=1},
                new ExecuteTask{taskID=5,SID="1552635",executeStatement=1}
            };
            executeTasks.ForEach(s => context.executeTasks.Add(s));
            var questions = new List<Question>
            {
                new Question{questionID=1,questionDate=new DateTime(2016,3,18),SID="1552635",title="something wrong",questionText="lalalala"}
            };
            questions.ForEach(s => context.questions.Add(s));
            var answers = new List<Answer>
            {
                new Answer{adminID="12",questionID=1,answerContext="mdzz"}
            };
            answers.ForEach(s => context.answers.Add(s));
            var applications = new List<Application>
            {
                new Application{SID="1552635",firstWill="组织部",secondWill="文艺部",unitWill= new Boolean[4],isSubject=false,changeMajoirWill=false,previousPosition=null,habbit=null,chooseHabit=null,chooseReason=null,workExperiments=null,expect=null}
            };
            applications.ForEach(s => context.applications.Add(s));
            
            context.SaveChanges();



            base.Seed(context);
        }
    }
}