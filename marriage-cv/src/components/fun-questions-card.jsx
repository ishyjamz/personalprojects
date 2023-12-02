import Button from 'react-bootstrap/Button';
import Card from 'react-bootstrap/Card';
import Izhush from '../images/izhush.jpg'
import { Link } from 'react-router-dom';

function FunQuestionsCard() {
  return (
    <Card>
      <Card.Img className='pic' variant="top" src={Izhush} alt='' />
      <Card.Body>
        <Card.Title>Fun Questions</Card.Title>
        <Card.Text>
          Take a look through these interesting questions
          that I have given my answer to. See if those answers
          match with what you would say.
        </Card.Text>
      </Card.Body>
      <Card.Footer>
        <Link to='/fun-questions'><Button id='click-here'>Click Here</Button></Link>
      </Card.Footer>
    </Card>
  );
}

export default FunQuestionsCard