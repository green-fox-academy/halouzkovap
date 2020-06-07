package com.example.todo.Repository;


import com.example.todo.Entity.User;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;

import java.util.Collection;
import java.util.stream.Collectors;

public class UserRepositoryUserDetailsService implements UserDetailsService {
    private final UserRepository users;

    public UserRepositoryUserDetailsService(UserRepository users) {
        this.users = users;
    }

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        return this.users.findByUserName(username)
                .map(BridgedUser::new)
                .orElseThrow(() -> new UsernameNotFoundException("no user"));
    }

    private static class BridgedUser extends User implements UserDetails {
        public BridgedUser(User user) {
            super(user);
        }

        @Override
        public Collection<? extends GrantedAuthority> getAuthorities() {
            return this.getAuthorities().stream()
                    .map(a -> new SimpleGrantedAuthority(a.getAuthority()))
                    .collect(Collectors.toList());
        }

        @Override
        public String getPassword() {
            return null;
        }

        @Override
        public String getUsername() {
            return null;
        }

        @Override
        public boolean isAccountNonExpired() {
            return this.isEnabled();
        }

        @Override
        public boolean isAccountNonLocked() {
            return this.isEnabled();
        }

        @Override
        public boolean isCredentialsNonExpired() {
            return this.isEnabled();
        }

        @Override
        public boolean isEnabled() {
            return false;
        }
    }
}
