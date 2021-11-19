import './App.css';
import React from 'react';

class App extends React.Component {

  constructor() {
    super();
    this.state = {
       data: 
       [
          { 
              "id":1, 
              "name":"Foo",
              "age":"20"
          },
          { 
              "id":2, 
              "name":"Bar",
              "age":"30"
          },
          { 
              "id":3, 
              "name":"Bear",
              "age":"40"
          }
       ]
    }
  }

  render(){
    return (
      <div>
        <Header></Header>
        <table>
            <thead>
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Age</th>
              </tr>
              
            </thead>
            <tbody>
              {this.state.data.map((person,i) => <TableRow key={i} data={person} />)}
            </tbody>
        </table>
      </div>
      
    );
  }

  // render() {

  //   // let i = 10;


  //   return(

  //     // <div>
  //     //   <p>Hello</p>
  //     //   <p data-myattribute='somevalue'>Nguyen Thi Van Anh</p>
  //     //   <p>Result : {1+1}</p>
  //     //   <h3>Check value : {i > 1 ? 'True' : 'False'}</h3>
  //     //   <h3 class="myClass">Style </h3>
  //     // </div>
  //     // <div>
  //     //   <Header></Header>
  //     //   <Content></Content>
  //     // </div>
  //     <div>
        
  //     </div>
  //   );
  // }

}  

// class Header extends React.Component{
//   render(){
//     return (
//       <div>
//         <h1>Header</h1>
//       </div>
//     );
//   }
// }

// class Content extends React.Component{
//   render(){
//     return (
//       <div>
//         <h2>Content</h2>
//         <p>THis is content text</p>
//       </div>
//     );
//   }
// }

class Header extends React.Component{
  render(){
    return(
      <div>
        <h1>Header</h1>
      </div>
    );
  }
}

class TableRow extends React.Component{
  render(){
    return(
      <tr>
        <td>{this.props.data.id}</td>
        <td>{this.props.data.name}</td>
        <td>{this.props.data.age}</td>
      </tr>
    );
  }
}

export default App;
