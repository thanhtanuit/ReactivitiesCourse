import axios from "axios";
import { useEffect, useState } from "react"
import { Header, List } from "semantic-ui-react";

function App() {
  const [activities, setActivities] = useState([]);
  useEffect(function(){
    axios.get('http://localhost:5000/api/activities')
    .then((response) => setActivities(response.data))
    .catch((error) => console.error(error));
    console.log(activities);
  },[]);

  return (
    <>
      <Header as="h2" icon="users" content="Reactivities" />
      <ul>
      <List>
        {activities.map((activity) => (
          <List.Item key={activity.id}>{activity.title}</List.Item>
        ))}
      </List>
       
      </ul>
    </>
    

  )
}

export default App
