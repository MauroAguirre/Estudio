package uy.edu.cei.generala.domain;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToOne;
import javax.persistence.Table;
import javax.persistence.UniqueConstraint;

@Entity
@Table(name = "users")
@NamedQueries({
		@NamedQuery(name = "UserModel.findByUsername", query = "SELECT user FROM UserModel user WHERE user.username = :username"),
		@NamedQuery(name = "UserModel.fetchAll", query = "SELECT user FROM UserModel user")
})
public class UserModel implements Serializable {

	/**
	 * Default UID
	 */
	private static final long serialVersionUID = 1L;
	@Id
	@GeneratedValue(strategy = GenerationType.SEQUENCE)
	private Long id;
	@Column(unique = true)
	private String username;
	private String password;
	@Column(name = "door_number")
	private String doorNumber;
	@OneToOne
	@JoinColumn
	private Address mainAddress;
	
	public UserModel() {
	}

	public UserModel(String username, String password) {
		this.username = username;
		this.password = password;
	}

	@Override
	public boolean equals(Object obj) {
		if (obj instanceof UserModel) {
			UserModel o = (UserModel) obj;
			return this.username.equals(o.username);
		}
		return false;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public Address getMainAddress() {
		return mainAddress;
	}

	public void setMainAddress(Address mainAddress) {
		this.mainAddress = mainAddress;
	}

}
