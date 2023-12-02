import Accordion from 'react-bootstrap/Accordion';

function Hobbies() {
  return (
    <Accordion style={{width: '500px'}}defaultActiveKey={['0']} alwaysOpen>
      <Accordion.Item eventKey="0">
        <Accordion.Header id='head'>My Hobbies</Accordion.Header>
        <Accordion.Body>
        My hobbies unironically are reading quran, coding dumb things like this website, playing sport, watching sport,
        islamic studies, gaming, anime etc etc
        </Accordion.Body>
      </Accordion.Item>
    </Accordion>
  );
}

export default Hobbies;