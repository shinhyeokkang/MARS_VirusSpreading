human <- read.csv(file="../src-gen/Human.csv",head=T, sep=";", dec="." )

attach(human)

max_human_steps <- max(human$Step)
gov <- min(Government_announce_date)

human_pop <- matrix(nrow = 1, ncol = max_human_steps)
human_rec <- matrix(nrow = 1, ncol = max_human_steps)
human_inf <- matrix(nrow = 1, ncol = max_human_steps)
human_d <- matrix(nrow = 1, ncol = max_human_steps)

after_gov <- max_human_steps-gov

R0_deadmid <- matrix(nrow = 1, ncol = after_gov)
R0_immmid <- matrix(nrow = 1, ncol = after_gov)
R0_midtotal <- matrix(nrow = 1, ncol = after_gov)
R0_midres <- matrix(nrow = 1, ncol = after_gov)


max_human <- nrow(subset(human,Step==0))

for (st in c(0:max_human_steps)) {
  human_pop[st] <- nrow(subset(human,Step==st))
  human_rec[st] <- nrow(subset(human,Step==st&Immune=='True'))

  human_d[st] <- max_human-nrow(subset(human,Step==st))
  human_inf[st] <- nrow(subset(human,Step==st&Infected=='True'))+human_d[st]+human_rec[st]

}

for (st in c(gov:max_human_steps)){
  R0_deadmid[st-gov] <- sum(subset(human,Step<=st&DeadTick=='True',select = R0))
  R0_immmid[st-gov] <- sum(subset(human,Step==st&Immune=='True',select = R0))

  R0_midtotal[st-gov] <- sum(R0_deadmid[st-gov])+sum(R0_immmid[st-gov])
  R0_midres[st-gov] <- sum(R0_midtotal[st-gov])/(sum(human_d[st])+sum(human_rec[st]))
  
}

max_inf <- max(human_inf)
max_R0 <- max(R0_midres)
jpeg(filename = "covid19.jpg",width = 800, height = 1000)

split.screen(c(2,1))

  
  screen(1)
  
plot(c(1:max(max_human_steps)), ylim = c(0,max_inf), type = "n", 
     xlab ="Simulation steps", ylab = "Infected Population")

box()
lines(human_rec[1,],col="green")
lines(human_d[1,],col="black")
lines(human_inf[1,],col="red")

abline(v=min(Government_announce_date),col="yellow",lty=2)
legend("topleft",legend=c("Infected","Recovered","Death","SocialDistance"), col=c("red","green","black","yellow"), lty = 1)

 screen(2)
 
 plot(c(gov:max_human_steps), ylim = c(0,max_R0),axes=F, type = "n", xlab ="Simulation Steps", ylab = "R0")
 
 axis(1,at=0:ncol(R0_midres),lab=c(gov:max_human_steps))
 axis(2,ylim=c(0,1.8))
 box()
 lines(R0_midres[1,],col="red")

close.screen(all=TRUE)

dev.off()