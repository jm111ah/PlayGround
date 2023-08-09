using Interface;
using Microsoft.Extensions.DependencyInjection;
using ProjectA;
using ProjectB;

#region DI 코드
/* 의존성 주입은 하나의 객체가 다른 객체의 의존성을 제공하는 테크닉 
    현재 작동하는 클래스 내부가 아닌 외부에서 객체를 생성한 후 그 객체를 제공하는 기술
 */

/*
 ServiceCollection : .NET5 이상에서 DI 관리하기 위해 사용되는 클래스
                      서비스를 구현하는 클래스를 등록하는 컨테이너 역할
                      등록된 서비스는 애플리케이션 전반에서 DI 사용 가능

AddScoped : DI 서비스 등록하는 역할
 */

ServiceCollection collection = new ServiceCollection();
collection.AddScoped<ProjectATest>();
collection.AddScoped<DI>();


collection.AddScoped<IProjectTest, ProjectBTest>();
collection.AddScoped<Inter>();

ServiceProvider provider = collection.BuildServiceProvider();
DI di = provider.GetService<DI>();
Inter interDI = provider.GetService<Inter>();

di.Play();
interDI.Play();

public class DI
{
    ProjectATest _project;

    public DI(ProjectATest projectA)
    {
        _project = projectA;
    }

    public void Play()
    {
        _project.Play();
    }

    public void Play2()
    {
        _project.Play();
    }

    public void Play3()
    {
        _project.Play();
    }

    public void Play4()
    {
        _project.Play();
    }

    public void Play5()
    {
        _project.Play();
    }
}

#endregion

#region 의존성 높은 코드

class Height
{
    void Play()
    {
        ProjectATest projectA = new ProjectATest();
        projectA.Play();
    }

    void Play2()
    {
        ProjectATest projectA = new ProjectATest();
        projectA.Play();
    }


    void Play3()
    {
        ProjectATest projectA = new ProjectATest();
        projectA.Play();
    }


    void Play4()
    {
        ProjectATest projectA = new ProjectATest();
        projectA.Play();
    }


    void Play5()
    {
        ProjectATest projectA = new ProjectATest();
        projectA.Play();
    }
}

#endregion

#region 의존성 낮은 코드

class Ctor
{
    ProjectATest _project;

    public Ctor()
    {
        _project = new ProjectATest();
    }

    void Play()
    {
        _project.Play();
    }

    void Play2()
    {
        _project.Play();
    }

    void Play3()
    {
        _project.Play();
    }

    void Play4()
    {
        _project.Play();
    }

    void Play5()
    {
        _project.Play();
    }


}

#endregion

#region 인터페이스 

public class Inter
{
    public IProjectTest _project;

    public Inter(IProjectTest project)
    {
        _project = project;
    }

    public void Play()
    {
        _project.Play();
    }

    public void Play2()
    {
        _project.Play();
    }

    public void Play3()
    {
        _project.Play();
    }

    public void Play4()
    {
        _project.Play();
    }

    public void Play5()
    {
        _project.Play();
    }
}

#endregion

