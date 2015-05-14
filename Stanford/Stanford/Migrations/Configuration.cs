namespace Stanford.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Stanford.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Stanford.Context.QuestionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Stanford.Context.QuestionContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            
            context.Questions.AddOrUpdate(
                    p => p.Id,
                    new Question { Id = 1, Q = "当你要外出一整天，你会", A = "计划你要做什么和在什么时候做", B = "说去就去" },
                    new Question { Id = 2, Q = "你认为自己是一个", A = "较为随兴所至的人", B = "较为有条理的人" },
                    new Question { Id = 3, Q = "假如你是一位老师，你会选教", A = "以事实为主的课程", B = "涉及理论的课程" },
                    new Question { Id = 4, Q = "你通常", A = "与人容易混熟", B = "比较沉静或矜持" },
                    new Question { Id = 5, Q = "一般来说，你和哪些人比较合得来？", A = "富于想象力的人", B = "现实的人" },
                    new Question { Id = 6, Q = "你是否经常让", A = "你的情感支配你的理智", B = "你的理智主宰你的情感" },
                    new Question { Id = 7, Q = "你的理智主宰你的情感", A = "凭兴所至行事", B = "按照计划行事" },
                    new Question { Id = 8, Q = "你是否", A = "容易让人了解", B = "难于让人了解" },
                    new Question { Id = 9, Q = "按照程序表做事", A = "合你心意", B = "令你感到束缚" },
                    new Question { Id = 10,Q = "当你有一份特别的任务，你会喜欢", A = "开始前小心组织计划", B = "边做边找须做什么" },
                    new Question { Id = 11,Q = "在大多数情况下，你会选择", A = "顺其自然", B = "按程序表做事" },
                    new Question { Id = 12,Q = "大多数人会说你是一个", A = "重视自我隐私的人", B = "非常坦率开放的人" },
                    new Question { Id = 13,Q = "你宁愿被人认为是一个", A = "实事求是的人", B = "机灵的人" },
                    new Question { Id = 14,Q = "在一大群人当中，通常是", A = "你介绍大家认识", B = "别人介绍你" },
                    new Question { Id = 15,Q = "你会跟哪些人做朋友", A = "常提出新注意的", B = "脚踏实地的" },
                    new Question { Id = 16,Q = "你倾向", A = "重视感情多于逻辑", B = "重视逻辑多于感情" },
                    new Question { Id = 17,Q = "你比较喜欢", A = "坐观事情发展才作计划", B = "很早就作计划" },
                    new Question { Id = 18,Q = "你喜欢花很多的时间", A = "一个人独处", B = "合别人在一起" },
                    new Question { Id = 19,Q = "与很多人一起会", A = "令你活力培增", B = "常常令你心力憔悴" },
                    new Question { Id = 20,Q = "你比较喜欢", A = "很早便把约会、社交聚集等事情安排妥当", B = "无拘无束，看当时有什么好玩就做什么" },
                    new Question { Id = 21,Q = "计划一个旅程时，你较喜欢", A = "大部分的时间都是跟当天的感觉行事", B = "事先知道大部分的日子会做什么" },
                    new Question { Id = 22,Q = "在社交聚会中，你", A = "有时感到郁闷", B = "常常乐在其中" },
                    new Question { Id = 23,Q = "你通常", A = "和别人容易混熟", B = "趋向自处一隅" },
                    new Question { Id = 24,Q = "哪些人会更吸引你？", A = "一个思想敏捷及非常聪颖的人", B = "b1实事求是，具丰富常识的人" },
                    new Question { Id = 25,Q = "在日常工作中，你会", A = "颇为喜欢处理迫使你分秒必争的突发", B = "通常预先计划，以免要在压力下工作" },
                    new Question { Id = 26, Q = "你认为别人一般", A = "要花很长时间才认识你", B = "用很短的时间便认识你" },
                    new Question { Id = 27, Q = "哪一个词语更合你心意？", A = "注重隐私", B = "坦率开放" },
                    new Question { Id = 28, Q = "哪一个词语更合你心意？", A = "预先安排的", B = "无计划的" },
                    new Question { Id = 29, Q = "哪一个词语更合你心意？", A = "抽象", B = "具体" },
                    new Question { Id = 30, Q = "哪一个词语更合你心意？", A = "温柔", B = "坚定" },
                    new Question { Id = 31, Q = "哪一个词语更合你心意？", A = "思考", B = "感受" },
                    new Question { Id = 32, Q = "哪一个词语更合你心意？", A = "事实", B = "意念" },
                    new Question { Id = 33, Q = "哪一个词语更合你心意？", A = "冲动", B = "决定" },
                    new Question { Id = 34, Q = "哪一个词语更合你心意？", A = "热衷", B = "文静" },
                    new Question { Id = 35, Q = "哪一个词语更合你心意？", A = "文静", B = "外向" },
                    new Question { Id = 36, Q = "哪一个词语更合你心意？", A = "有系统", B = "随意" },
                    new Question { Id = 37, Q = "哪一个词语更合你心意？", A = "理论", B = "肯定" },
                    new Question { Id = 38, Q = "哪一个词语更合你心意？", A = "敏感", B = "公正" },
                    new Question { Id = 39, Q = "哪一个词语更合你心意？", A = "令人信服", B = "感人的" },
                    new Question { Id = 40, Q = "哪一个词语更合你心意？", A = "声明", B = "概念" },
                    new Question { Id = 41, Q = "哪一个词语更合你心意？", A = "不受约束", B = "预先安排" },
                    new Question { Id = 42, Q = "哪一个词语更合你心意？", A = "矜持", B = "健谈" },
                    new Question { Id = 43, Q = "哪一个词语更合你心意？", A = "有条不紊", B = "不拘小节" },
                    new Question { Id = 44, Q = "哪一个词语更合你心意？", A = "意念", B = "实况" },
                    new Question { Id = 45, Q = "哪一个词语更合你心意？", A = "同情怜悯", B = "远见" },
                    new Question { Id = 46, Q = "哪一个词语更合你心意？", A = "利益", B = "祝福" },
                    new Question { Id = 47, Q = "哪一个词语更合你心意？", A = "务实的", B = "理论的" },
                    new Question { Id = 48, Q = "哪一个词语更合你心意？", A = "朋友不多", B = "朋友众多" },
                    new Question { Id = 49, Q = "哪一个词语更合你心意？", A = "有系统", B = "即兴" },
                    new Question { Id = 50, Q = "哪一个词语更合你心意？", A = "富想象的", B = "以事论事" },
                    new Question { Id = 51, Q = "哪一个词语更合你心意？", A = "亲切的", B = "客观的" },
                    new Question { Id = 52, Q = "哪一个词语更合你心意？", A = "客观的", B = "热情的" },
                    new Question { Id = 53, Q = "哪一个词语更合你心意？", A = "建造", B = "发明" },
                    new Question { Id = 54, Q = "哪一个词语更合你心意？", A = "文静", B = "爱合群" },
                    new Question { Id = 55, Q = "哪一个词语更合你心意？", A = "理论", B = "事实" },
                    new Question { Id = 56, Q = "哪一个词语更合你心意？", A = "富同情", B = "合逻辑" },
                    new Question { Id = 57, Q = "哪一个词语更合你心意？", A = "具分析力", B = "多愁善感" },
                    new Question { Id = 58, Q = "哪一个词语更合你心意？", A = "合情合理", B = "令人着迷" },
                    new Question { Id = 59, Q = "当你要在一个星期内完成一个大项目，你在开始的时候会", A = "把要做的不同工作依次列出", B = "马上动工" },
                    new Question { Id = 60, Q = "在社交场合中，你经常会感到", A = "与某些人很难打开话匣儿和保持对话", B = "与多数人都能从容地长谈" },
                    new Question { Id = 61, Q = "要做许多人也做的事，你比较喜欢", A = "按照一般认可的方法去做", B = "构想一个自己的想法" },
                    new Question { Id = 62, Q = "你刚认识的朋友能否说出你的兴趣？", A = "马上可以", B = "要待他们真正了解你之后才可以" },
                    new Question { Id = 63, Q = "你通常较喜欢的科目是", A = "讲授概念和原则的", B = "讲授事实和数据的" },
                    new Question { Id = 64, Q = "哪个是较高的赞誉，或称许为？", A = "一贯感性的人", B = "一贯理性的人" },
                    new Question { Id = 65, Q = "你认为按照程序表做事", A = "有时是需要的，但一般来说你不大喜欢这样做，或是", B = "大多数情况下是有帮助而且是你喜欢做的" },
                    new Question { Id = 66, Q = "和一群人在一起，你通常会选", A = "跟你很熟悉的个别人谈话", B = "参与大伙的谈话" },
                    new Question { Id = 67, Q = "在社交聚会上，你会", A = "是说话很多的一个", B = "让别人多说话" },
                    new Question { Id = 68, Q = "把周末期间要完成的事列成清单，这个主意会", A = "合你意", B = "使你提不起劲" },
                    new Question { Id = 69, Q = "哪个是较高的赞誉，或称许为", A = "能干的", B = "富有同情心" },
                    new Question { Id = 70, Q = "你通常喜欢", A = "事先安排你的社交约会", B = "随兴之所至做事" },
                    new Question { Id = 71, Q = "总的说来，要做一个大型作业时，你会选", A = "边做边想该做什么", B = "首先把工作按步细分" },
                    new Question { Id = 72, Q = "你能否滔滔不绝地与人聊天", A = "只限于跟你有共同兴趣的人", B = "几乎跟任何人都可以" },
                    new Question { Id = 73, Q = "你会", A = "跟随一些证明有效的方法，或是", B = "分析还有什么毛病，及针对尚未解决的难题" },
                    new Question { Id = 74, Q = "为乐趣而阅读时，你会", A = "喜欢奇特或创新的表达方式", B = "喜欢作者直话直说" },
                    new Question { Id = 75, Q = "你宁愿替哪一类上司（或者老师）工作？", A = "天性淳良，但常常前后不一的", B = "言词尖锐但永远合乎逻辑的" },
                    new Question { Id = 76, Q = "你做事多数是", A = "按当天心情去做", B = "照拟好的程序表去做" },
                    new Question { Id = 77, Q = "你是否", A = "可以和任何人按需求从容地交谈，或是", B = "只是对某些人或在某种情况下才可以畅所欲言" },
                    new Question { Id = 78, Q = "要作决定时，你认为比较重要的是", A = "据事实衡量", B = "考虑他人的感受和意见" },
                    new Question { Id = 79, Q = "哪一个词语更合你心意？", A = "想象的", B = "真实的" },
                    new Question { Id = 80, Q = "哪一个词语更合你心意？", A = "仁慈慷慨的", B = "意志坚定的" },
                    new Question { Id = 81, Q = "哪一个词语更合你心意？", A = "公正的", B = "有关怀心" },
                    new Question { Id = 82, Q = "哪一个词语更合你心意？", A = "制作", B = "设计" },
                    new Question { Id = 83, Q = "哪一个词语更合你心意？", A = "可能性", B = "必然性" },
                    new Question { Id = 84, Q = "哪一个词语更合你心意？", A = "温柔", B = "力量" },
                    new Question { Id = 85, Q = "哪一个词语更合你心意？", A = "实际", B = "多愁善感" },
                    new Question { Id = 86, Q = "哪一个词语更合你心意？", A = "制造", B = "创造" },
                    new Question { Id = 87, Q = "哪一个词语更合你心意？", A = "新颖的", B = "已知的" },
                    new Question { Id = 88, Q = "哪一个词语更合你心意？", A = "同情", B = "分析" },
                    new Question { Id = 89, Q = "哪一个词语更合你心意？", A = "坚持己见", B = "温柔有爱心" },
                    new Question { Id = 90, Q = "哪一个词语更合你心意？", A = "具体的", B = "抽象的" }, 
                    new Question { Id = 91, Q = "哪一个词语更合你心意？", A = "全心投入", B = "有决心的" },
                    new Question { Id = 92, Q = "哪一个词语更合你心意？", A = "能干", B = "仁慈" },
                    new Question { Id = 93, Q = "哪一个词语更合你心意？", A = "实际", B = "创新" }
                );
            /*
            1. University of Michigan ​Ann Arbor
            
             * 
             * 
             * context.Universities.AddOrUpdate(
                p=>p.Id,


                );

            context.Jobs.AddOrUpdate(
                p=>p.Id,


                );
             */

            
            List<Job> INFJjobs = new List<Job>();
            List<Major> majors = new List<Major>();
            majors.Add(new Major("Major1"));
            majors.Add(new Major("Major2"));
            majors.Add(new Major("Major3"));

            INFJjobs.Add(new Job("心理咨询工作者", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("心理诊疗师", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("职业指导顾问", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("大学教师", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("作家", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("诗人", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("电影编剧", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("电影导演", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("画家", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("雕塑家", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("音乐家", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("艺术顾问", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("建筑师", "Major1,Major2,Major3"));
            INFJjobs.Add(new Job("设计师", "Major1,Major2,Major3"));

            context.Jobs.AddOrUpdate(
                p=>p.Job_Id,
                new Job("心理咨询工作者", "<ol><li>MMM</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("心理诊疗师", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("职业指导顾问", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("大学教师", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("作家", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("诗人", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("电影编剧", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("电影导演", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("画家", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("雕塑家", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("音乐家", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("艺术顾问", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("建筑师", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>"),
                new Job("设计师", "<ol><li>Major1</li>,<li>Major2</li>,<li>Major3</li></ol>")

                );

            /*
                1. INFJ
            
             */
            ChrTrait INFJ = new ChrTrait(1, "INFJ", "心理咨询工作者,心理诊疗师,职业指导顾问,大学教师,作家,诗人,电影编剧,电影导演,画家,雕塑家,音乐家,艺术顾问,建筑师,设计师", INFJjobs);

            context.Traits.AddOrUpdate(
                p=>p.Id,
                INFJ
                );


        }
    }
}
