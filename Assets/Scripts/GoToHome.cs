using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToHome : MonoBehaviour {

    public Text displayText;
    public GameObject displayImage;
    public GameObject Home;
    public GameObject Clear;
    public GameObject goBack;

    //panels
    public GameObject SendToPanel;
    public GameObject HomePanel;
    public GameObject QuestionsPanel;
    public GameObject PeoplePanel;
    public GameObject ActionsPanel;
    public GameObject MoreActionsPanel;
    public GameObject DescribePanel;
    public GameObject MoreDescribePanel;
    public GameObject ThingsPanel;
    public GameObject WantPanel;
    public GameObject INeedPanel;
    public GameObject PlacesPanel;
    public GameObject FeelingsPanel;
    public GameObject ChatPanel;

    //Home buttons
    public GameObject Questions;
    public GameObject Things;
    public GameObject dontWant;
    public GameObject Actions;
    public GameObject homePeople;
    public GameObject want;
    public GameObject Describe;
    public GameObject need;
    public GameObject Places;
    public GameObject feel;
    public GameObject Chat;

    //Questions buttons
    public GameObject who;
    public GameObject what;
    public GameObject where;
    public GameObject when;
    public GameObject why;
    public GameObject how;
    public GameObject howMuch;
    public GameObject howLong;
    public GameObject whereGoing;
    public GameObject whatsUp;
    public GameObject whatDoing;
    public GameObject whatsHappen;
    
    //People buttons
    public GameObject Dad;
    public GameObject Mom;
    public GameObject People;
    public GameObject I;
    public GameObject me;
    public GameObject she;
    public GameObject he;
    public GameObject you;
    public GameObject and;
    
    //Actions buttons
    public GameObject buy;
    public GameObject call;
    public GameObject come;
    public GameObject cook;
    public GameObject drink;
    public GameObject eat;
    public GameObject give;
    public GameObject go;
    public GameObject help;
    public GameObject hurt;
    public GameObject jump;
    public GameObject like;
    public GameObject MoreActions;
    
    //MoreActions buttons
    public GameObject play;
    public GameObject read;
    public GameObject ride;
    public GameObject run;
    public GameObject sleep;
    public GameObject stop;
    public GameObject swing;
    public GameObject talk;
    public GameObject walk;
    public GameObject wantAction;
    public GameObject watch;
    public GameObject work;
    
    //Describe buttons
    public GameObject nice;
    public GameObject mean;
    public GameObject good;
    public GameObject describeBad;
    public GameObject big;
    public GameObject small;
    public GameObject favorite;
    public GameObject colors;
    public GameObject feelings;
    public GameObject weather;
    public GameObject describeWhere;
    public GameObject moreDescribe;
    
    //More Describe buttons
    
    //Things buttons
    
    //Want buttons
    
    //Need buttons
    
    //Places buttons
    
    //Feelings buttons
    public GameObject angry;
    public GameObject bad;
    public GameObject bored;
    public GameObject confused;
    public GameObject excited;
    public GameObject fine;
    public GameObject frustrated;
    public GameObject happy;
    public GameObject pain;
    public GameObject sad;
    public GameObject scared;
    public GameObject tired;
    
    //Chat buttons
    public GameObject Hello;
    public GameObject gmorn;
    public GameObject gnight;
    public GameObject howYou;
    public GameObject gbye;
    public GameObject whatName;
    public GameObject myName;
    
    public void GoToHomeScreen()
    {
        displayImage.SetActive(true);
        Home.SetActive(false);
        Clear.SetActive(true);
        goBack.SetActive(false);
        HomePanel.SetActive(true);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToQuestions()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(true);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToPeople()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(true);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToActions()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(true);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToMoreActions()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(true);
        DescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToDescribe()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(true);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToMoreDescribe()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(true);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToThings()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(true);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToWants()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(true);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToNeeds()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(true);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToPlaces()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(true);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(false);
    }

    public void GoToFeelings()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(true);
        ChatPanel.SetActive(false);
    }

    public void GoToChat()
    {
        displayImage.SetActive(true);
        Clear.SetActive(true);
        Home.SetActive(true);
        goBack.SetActive(true);
        HomePanel.SetActive(false);
        SendToPanel.SetActive(false);
        QuestionsPanel.SetActive(false);
        PeoplePanel.SetActive(false);
        ActionsPanel.SetActive(false);
        MoreActionsPanel.SetActive(false);
        DescribePanel.SetActive(false);
        MoreDescribePanel.SetActive(false);
        ThingsPanel.SetActive(false);
        WantPanel.SetActive(false);
        INeedPanel.SetActive(false);
        PlacesPanel.SetActive(false);
        FeelingsPanel.SetActive(false);
        ChatPanel.SetActive(true);
    }

    public void Changetext()
    {
        displayText.text = "home";
    }

    public void Changetextt()
    {
        displayText.text = displayText + "go back";
    }

    public void DisplayText()
    {
        Button h = Home.GetComponent<Button>();
        h.onClick.AddListener(Changetext);
        Button gb = goBack.GetComponent<Button>();
        gb.onClick.AddListener(Changetextt);
    }

    public void ClearText()
    {
        displayText.text = "";
    }

    public void BackToHome()
    {
        Button btn = Home.GetComponent<Button>();
        btn.onClick.AddListener(GoToHomeScreen);
    }

    public void HomeButtons() {
        Button q = Questions.GetComponent<Button>();
        Button w = want.GetComponent<Button>();
        Button dw = dontWant.GetComponent<Button>();
        Button a = Actions.GetComponent<Button>();
        Button hp = homePeople.GetComponent<Button>();
        Button d = Describe.GetComponent<Button>();
        Button t = Things.GetComponent<Button>();
        Button n = need.GetComponent<Button>();
        Button pl = Places.GetComponent<Button>();
        Button f = feel.GetComponent<Button>();
        Button c = Chat.GetComponent<Button>();
        q.onClick.AddListener(GoToQuestions);
        w.onClick.AddListener(GoToWants);
        dw.onClick.AddListener(GoToWants);
        a.onClick.AddListener(GoToActions);
        hp.onClick.AddListener(GoToPeople);
        d.onClick.AddListener(GoToDescribe);
        t.onClick.AddListener(GoToThings);
        n.onClick.AddListener(GoToNeeds);
        pl.onClick.AddListener(GoToPlaces);
        f.onClick.AddListener(GoToFeelings);
        c.onClick.AddListener(GoToChat);
    }

    void Start()
        {
            displayImage.SetActive(false);
            displayText.text = "";
            Home.SetActive(false);
            Clear.SetActive(false);
            goBack.SetActive(false);
            SendToPanel.SetActive(true);
            HomePanel.SetActive(false);
            QuestionsPanel.SetActive(false);
            PeoplePanel.SetActive(false);
            ActionsPanel.SetActive(false);
            MoreActionsPanel.SetActive(false);
            DescribePanel.SetActive(false);
            MoreDescribePanel.SetActive(false);
            ThingsPanel.SetActive(false);
            WantPanel.SetActive(false);
            INeedPanel.SetActive(false);
            PlacesPanel.SetActive(false);
            FeelingsPanel.SetActive(false);
            ChatPanel.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
        HomeButtons();
        BackToHome();
        DisplayText();
    }

}
